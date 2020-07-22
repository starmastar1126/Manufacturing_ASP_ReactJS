using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzyFindMobileApi.General;
using EzyFindMobileApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace EzyFindMobileApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        Response response = new Response();

        IConfiguration Configuration;

        public LoginController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // GET: api/Login/username/password       
        [HttpGet("{username}/{passwordStr}", Name = "GetLogin")]
        public async Task<IActionResult> GetLogin(string username, string passwordStr)
        {
            //string password = "sdfdf0";
            Dictionary<string, object> ClientResponse = new Dictionary<string, object>();
            // Add Response
            ClientResponse.Add("Response", response);

            try
            {
                string password = Model.EncryptDecrypt.Encrypt(passwordStr);
                // var mSTUsers = await db.MstUsers.FindAsync(username, password); /stdbank@ezyfind.co.za/Parts3455
                var mSTUsers = await db.MstUsers.Where(u => u.UserName == username & u.Password == password).FirstOrDefaultAsync();
                if (mSTUsers != null)
                {
                    if (mSTUsers.StatusId == 5)
                    {
                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Your account is not active.";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                    }
                    else
                    {
                        
                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Username and password valid";   // Exception Message
                        response.Result = mSTUsers;
                       
                        return Ok(response);
                    }
                      
                }
                else if (mSTUsers == null)
                {
                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Invalid User Name and Password";   // Exception Message
                    response.Result = null;
                    return Ok(response);

                }               
                else
                {
                    response.Status = false;                // Operation Status Indicator
                    response.Message = "Credentials not valid : Unknown Error";   // Exception Message
                    response.Result = null;
                    return Ok(response);
                }

            }
            catch (Exception exception)
            {
                //return BadRequest();

                response.Status = false;                // Operation Status Indicator
                response.Message = exception.Message;   // Exception Message
                response.Result = null;
                return Ok(response);
            }


        }

         
        [HttpPost]
        public async Task<IActionResult> SpGetLogin([FromBody] in_usp_GetUsersList mIn_usp_GetUsersList)
        {
            //Facebook test call  "FacebookUserID": 1905309716398105, "intTrack": 3,

            //@intTrack, --1 - Login , 2 - Search , 3 - FacebookCheck, 4 - GoogleCheck, 5 - Business User List, 12 - UserName , 13 - Email Exists , 14 - Contact No
            Dictionary<string, object> ClientResponse = new Dictionary<string, object>();
            // Add Response
            ClientResponse.Add("Response", response);
            string password = null;


            try
            {
                if (!String.IsNullOrEmpty(mIn_usp_GetUsersList.Password))
                {
                    password  = Model.EncryptDecrypt.Encrypt(mIn_usp_GetUsersList.Password);
                }

                //test url https://localhost:44326/api/login/SpGetLogin/stdbank@ezyfind.co.za/stdbank@ezyfind.co.za/stdbank@ezyfind.co.za/Parts3455/1/1/SDFDSFDSFDS@#$#DSFDSFDSFDSF
                // var mUsp_GetUsersList = await db.Query<out_usp_GetUsersList>().FromSql($"usp_GetUsersList @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13",null, mIn_usp_GetUsersList.Email, mIn_usp_GetUsersList.ContactNo, mIn_usp_GetUsersList.UserName, null,null, null, null,null, null,null, mIn_usp_GetUsersList.Password, mIn_usp_GetUsersList.Track, null).AsNoTracking().FirstOrDefaultAsync();
                var mUsp_GetUsersList = await db.Query<out_usp_GetUsersList>().FromSql($"usp_GetUsersList @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13", mIn_usp_GetUsersList.userID, mIn_usp_GetUsersList.Email, mIn_usp_GetUsersList.ContactNo, mIn_usp_GetUsersList.UserName, mIn_usp_GetUsersList.FacebookUserID, mIn_usp_GetUsersList.GoogleUserID, mIn_usp_GetUsersList.LinkedInUserID, mIn_usp_GetUsersList.ForgetPasswordCode, mIn_usp_GetUsersList.RoleID, mIn_usp_GetUsersList.StatusID, mIn_usp_GetUsersList.Name, password, mIn_usp_GetUsersList.intTrack, null).AsNoTracking().FirstOrDefaultAsync();


                if (mUsp_GetUsersList != null)
                    {
                        if (mUsp_GetUsersList.userID == 5)
                        {
                            response.Status = true;                // Operation Status Indicator
                            response.Message = "Your account is not active.";   // Exception Message
                            response.Result = null;
                            return Ok(response);
                        }
                        else
                        {
                            //Update users device info on a valid login (This is required as the user might change devices and notifications should go to that device.)
                            var mMstUsers = await db.MstUsers.FindAsync(mUsp_GetUsersList.userID);
                            using (EzyFind_DevContext db = new EzyFind_DevContext())
                            {
                                mMstUsers.DeviceId = mIn_usp_GetUsersList.DeviceID;
                                mMstUsers.DeviceType = mIn_usp_GetUsersList.DeviceType;
                            // JwtExtensions.GenerateToken(mMstUsers, _configuration);
                            var secrete = Configuration.GetSection("Keys").GetSection("JwtSecretKey").Value;
                            var token = new JwtTokenBuilder()
                               .AddSecurityKey(JwtSecurityKey.Create(Configuration.GetValue<string>("JwtSecretKey")))
                               .AddIssuer(Configuration.GetValue<string>("JwtIssuer"))
                               .AddAudience(Configuration.GetValue<string>("JwtAudience"))
                               .AddExpiry(90)
                               .AddClaim("Id", mMstUsers.UserId.ToString())
                               .AddRole(mUsp_GetUsersList.roleName)
                               .Build();

                            //eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIiLCJqdGkiOiI5MDFhNTVlYi1iNGI5LTQwMDctYmVkZi0wMWRkN2JlZWQxNDYiLCJJZCI6IjExMjczIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiTWFpbiBCdXNpbmVzcyBVc2VyIiwiZXhwIjoxNTYyMDc2OTY0LCJpc3MiOiJ3d3cuRXp5RmluZC5jby56YSIsImF1ZCI6Ind3dy5FenlGaW5kLmNvLnphIn0.75b1CapN64_AudLhvW4uDOMPKiKAsAAuCs805Ytu51c

                            //Main Business User
                            //ValidTo = { 2019 / 07 / 02 14:16:04}
                            //11273

                            mMstUsers.Token = token.Value;

                            db.MstUsers.Update(mMstUsers);
                                await db.SaveChangesAsync();

                           // configuration.GetSection("Keys").GetSection("MobileSmsAPI_Password").Value


                           

                        }

                            response.Status = true;                // Operation Status Indicator
                            response.Message = "Username and password valid";   // Exception Message
                            response.Result = mUsp_GetUsersList;

                            return Ok(response);
                        }

                    }
                    else if (mUsp_GetUsersList == null)
                    {
                        response.Status = true;                // Operation Status Indicator
                        response.Message = "Invalid User Name and Password";   // Exception Message
                        response.Result = null;
                        return Ok(response);

                    }
                    else
                    {
                        response.Status = false;                // Operation Status Indicator
                        response.Message = "Credentials not valid : Unknown Error";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                    }               

            }
            catch (Exception exception)
            {
                response.Status = false;                // Operation Status Indicator
                response.Message = exception.Message;   // Exception Message
                response.Result = null;
                return Ok(response);
            }
        }

        //Social login will follow the following steps
        //1. Check if current Social token and social UserID exists
        //2. Check if the email passed exists. This will eliminate if the same email address is already registered & an Oauth needs to be assigned to this user.
        //3. If the Oauth token or email does not exist. Create a new USER and assign the Oauth credentials to that user.
        //Send email and mobile if the user does not exists. This service call will create one
        //{Type} is the social media login flag fb, goolge, linkedin
        [HttpGet("{accesstoken}/{userid}/{email}/{mobile}/{type}", Name = "GetSocialLogin")]
        public async Task<IActionResult> GetSocialLogin(string accesstoken, string userid, string email, string mobile, string socialType)
        {
            
            Dictionary<string, object> ClientResponse = new Dictionary<string, object>();
            // Add Response
            ClientResponse.Add("Response", response);

            try
            {
 
                var mSTUsersSetting = await db.MapUsersSettings.Where(u => u.AccessToken == accesstoken & u.SUserId == userid).FirstOrDefaultAsync();
                if (mSTUsersSetting == null & !String.IsNullOrEmpty(email))
                {
                    int id = 0;
                    var mSTUsers = await db.MstUsers.Where(u => u.Email == email).FirstOrDefaultAsync();
                    id = mSTUsers.UserId;

                    MapUsersSettings mMapUsersSettings = new MapUsersSettings();

                    mMapUsersSettings.UserId = id;
                    mMapUsersSettings.AccessToken = accesstoken;
                    mMapUsersSettings.SUserId = userid;
                    mMapUsersSettings.SPost = false;
                    switch (socialType)
                    {
                        case "fb":
                            mMapUsersSettings.SettingId = 1;
                            break;
                        case "google":
                            mMapUsersSettings.SettingId = 2;
                            break;
                        case "linkedin":
                            mMapUsersSettings.SettingId = 11;
                            break;

                    }

                    db.MapUsersSettings.Add(mMapUsersSettings);
                    await db.SaveChangesAsync();

                    response.Status = true;                // Operation Status Indicator
                    response.Message = "Social login added by email";   // Exception Message
                    response.Result = mSTUsers;
                    return Ok(response);


                }
                else if (mSTUsersSetting == null)
                {
                    int id = 0;

                    using (EzyFind_DevContext db = new EzyFind_DevContext())
                    {
                        MstUsers mMstUsers = new MstUsers();
                        mMstUsers.UserName = email;
                        mMstUsers.Email = email;
                        mMstUsers.ContactNo = mobile;

                        db.MstUsers.Add(mMstUsers);
                        db.SaveChanges();
                        id = mMstUsers.UserId;

                        MapUsersSettings mMapUsersSettings = new MapUsersSettings();

                        mMapUsersSettings.UserId = id;
                        mMapUsersSettings.AccessToken = accesstoken;
                        mMapUsersSettings.SUserId = userid;
                        mMapUsersSettings.SPost = false;
                        switch (socialType)
                        {
                            case "fb":
                                mMapUsersSettings.SettingId = 1;
                                break;
                            case "google":
                                mMapUsersSettings.SettingId = 2;
                                break;
                            case "linkedin":
                                mMapUsersSettings.SettingId = 11;
                                break;

                        }

                        db.MapUsersSettings.Add(mMapUsersSettings);
                        await db.SaveChangesAsync();

                        var mSTUsers = await db.MstUsers.Where(u => u.UserId == mSTUsersSetting.UserId).FirstOrDefaultAsync();

                        response.Status = true;                // Operation Status Indicator
                        response.Message = "user created & confirmed Social login valid";   // Exception Message
                        response.Result = mSTUsers;
                        return Ok(response);

                    }

                }
                else
                {
                    var mSTUsers = await db.MstUsers.Where(u => u.UserId == mSTUsersSetting.UserId).FirstOrDefaultAsync();

                    if (mSTUsers != null)
                    {
                        if (mSTUsers.StatusId == 5)
                        {
                            response.Status = true;                // Operation Status Indicator
                            response.Message = "Your account is not active.";   // Exception Message
                            response.Result = null;
                            return Ok(response);
                        }
                        else
                        {
                            response.Status = true;                // Operation Status Indicator
                            response.Message = "Social login valid";   // Exception Message
                            response.Result = mSTUsers;
                            return Ok(response);
                        }

                    }
                    else
                    {
                        response.Status = false;                // Operation Status Indicator
                        response.Message = "An error occurred when retrieving a user. Try again :";   // Exception Message
                        response.Result = null;
                        return Ok(response);
                    }
                }

            }
            catch (Exception exception)
            {
                //return BadRequest();

                response.Status = false;                // Operation Status Indicator
                response.Message = exception.Message;   // Exception Message
                response.Result = null;
                return Ok(response);
            }          

        }
       
    }
}
