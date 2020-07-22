using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzyFindMobileApi.General;
using EzyFindMobileApi.Model;
using Microsoft.AspNetCore.Mvc;


namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();



        // GET api/<controller>/1009
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                
                   //await GetUserById(id);
                   var mSTUsers = await db.MstUsers.FindAsync(id);
                if(mSTUsers == null)
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : User found";   // Exception Message
                    response.Result = mSTUsers;
                    return Ok(response);
                }
                
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to get user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody]MstUsers mMstUsers, int platform)
        {
            //platform 0 = mobile (Only send SMS if registered via mobile)
            //1 = web
            try
            {
                
                if (mMstUsers != null)
                {
                    int id = 0;
                    int mCode;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        mCode = Utils.GenerateRandomNo();
                        mMstUsers.MobileActivationCode = mCode.ToString();
                        mMstUsers.EmailActivationCode = EncryptDecrypt.Encrypt(Guid.NewGuid().ToString() + mMstUsers.Email);

                        db.MstUsers.Add(mMstUsers);
                        await db.SaveChangesAsync();
                        id = mMstUsers.UserId;

                        if (platform == 0)
                        {
                            //Generate pass code for mobile registration                           
                            await Utils.SendSMSAsync(mMstUsers.ContactNo, mMstUsers.UserId, mCode.ToString());
                           
                        }
                        else
                        {
                            //Send email for web registration

                          
                        }

                        

                    }
                    var mSTUsers = await db.MstUsers.FindAsync(id);

                   
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : User registered";   // Exception Message
                    response.Result = mSTUsers;
                    return Ok(response);
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : Provide user to register";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to register user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> RegisterBusiness([FromBody]MstUsers mMstUsers, MstCompany mCompany)
        {
            try
            {
                
                if (mMstUsers != null)
                {
                    int id = 0;
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {

                        //Generate random number without 0 - Zero (As the user cant identify the difference between 0 and O)
                        var exclude = new HashSet<int>() { 0 };
                        var range = Enumerable.Range(1, 100).Where(i => !exclude.Contains(i));
                        var random = new Random();
                        int mCode = random.Next(1, 9999 - exclude.Count);

                        mMstUsers.CountryId = 1;
                        mMstUsers.StatusId = 2;
                        mMstUsers.RoleId = 4;
                        
                        mMstUsers.EmailActivationCode = EncryptDecrypt.Encrypt(Guid.NewGuid().ToString() + mMstUsers.Email);
                        mMstUsers.MobileActivationCode = mCode.ToString();
                        db.MstUsers.Add(mMstUsers);
                        await db.SaveChangesAsync();
                        id = mMstUsers.UserId;

                    }

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                       // mCompany
                    }

                        response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : User updated";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }



        // PUT api/<controller>/5
        [HttpPut("{id}/{email}/{mobile}")]
        public async Task<IActionResult> UpdateUserEmailMobile(int id, string email, string mobile)
        {
            try
            {
                var mMstUsers = await db.MstUsers.FindAsync(id);

                if(mMstUsers != null)
                {
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {                        
                        mMstUsers.UserName = email;
                        mMstUsers.Email = email;
                        mMstUsers.ContactNo = mobile;

                        db.MstUsers.Update(mMstUsers);
                        await db.SaveChangesAsync();

                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : User updated";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
           
        }

        [HttpPut("{id}/{password}")]
        public async Task<IActionResult> UpdateUserPassword(int id, string oldPassword, string newPassword)
        {
            try
            {
                if(oldPassword.Trim() == newPassword.Trim())
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Old & New Password Cannot Be The Same.";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                var mMstUsers = await db.MstUsers.FindAsync(id);
                
                if (mMstUsers != null)
                {
                    if(mMstUsers.Password != oldPassword)
                    {
                        using (EzyFind_DevContext db = new EzyFind_DevContext())
                        {
                            mMstUsers.Password = EncryptDecrypt.Encrypt(newPassword.Trim());

                            db.MstUsers.Update(mMstUsers);
                            await db.SaveChangesAsync();

                        }

                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Successful : User Password updated";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                    }
                    else
                    {
                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Incorrect Old Password";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                    }
                   
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to update user password";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> ForgetPassword(int id)
        {
            try
            {
               
                var mMstUsers = await db.MstUsers.FindAsync(id);

                if (mMstUsers != null)
                {
                   
                       
                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Mail has been sent! Please check your mail box.";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                   

                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to recover password";   // Exception Message
                response.Result = null;
                return Ok(response);
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserLocation(int id)
        {
            try
            {
                string[] strData = new string[10];
                
                //await GetUserById(id);
                var mSTUsers = await db.MstUsers.FindAsync(id);
                response.Status = true;                // Operation Status Indicator
                response.Message = "Successful : User found";   // Exception Message
                response.Result = strData;
                return Ok(response);
            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to get user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                var mMstUsers = await db.MstUsers.FindAsync(id);

                if (mMstUsers != null)
                {
                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {                     

                       // db.MstUsers.Remove(mMstUsers);
                       // await db.SaveChangesAsync();
                    }

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Successful : User deleted";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }
                else
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Warning : User not found";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = "Error : Unable to delete user";   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }
    }
}
