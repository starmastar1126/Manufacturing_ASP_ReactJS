using EzyFindMobileApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzyFindMobileApi.General
{
    public class EmailInfo
    {
        private EzyFind_DevContext db = new EzyFind_DevContext();
        //private static BL_MailFormat objBLMailFormat = new BL_MailFormat();
        private static MstMailType mMailType = new MstMailType();
        private static string strHeader = "", strFooter = "";

        private void IndividualRegistration(MstUsers mMstUsers)
        {
            StringBuilder sbIndividualRegistration = new StringBuilder();

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 1).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);
            sbIndividualRegistration.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[code]", mMstUsers.EmailActivationCode).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbIndividualRegistration.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();


        }

        private static string AddImagePath(String body)
        {

            string strLogoPath = "http://www.EzyFind.co.za/Images/logo.png";
            string strFacebookIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";
            string strGoogleIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";
            string strTwitterIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";
            string strAndroidIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";
            string strIphoneIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";
            string strWindowsIcon = "http://www.EzyFind.co.za/Images/fb_icon.png";

            return body.Replace("[LogoPath]", strLogoPath).Replace("[FacebookIcon]", strFacebookIcon).Replace("[GooglePlusIcon]", strGoogleIcon).Replace("[TwitterIcon]", strTwitterIcon).Replace("[AndroidIcon]", strAndroidIcon).Replace("[IphoneIcon]", strIphoneIcon).Replace("[WindowsIcon]", strWindowsIcon);

        }

        private void SendUserNamePassword(MstUsers mMstUsers)
        {
            StringBuilder sbSendUserNamePassword = new StringBuilder();

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 8).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);
            sbSendUserNamePassword.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[code]", mMstUsers.EmailActivationCode).Replace("[Password]", mMstUsers.Password).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbSendUserNamePassword.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();

        }

        private void SendUserNamePasswordFromAdmin(MstUsers mMstUsers)
        {
            StringBuilder sbSendUserNamePassword = new StringBuilder();

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 13).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);
            //sbSendUserNamePassword.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[UserName]", mMstUsers.LoginName).Replace("[Password]", mMstUsers.Password).Replace("[SiteURL]", "www.EzyFind.co.za"));
            sbSendUserNamePassword.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[Password]", mMstUsers.Password).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbSendUserNamePassword.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();
        }


        private void ForgetPassword(MstUsers mMstUsers)
        {
            StringBuilder sbForgetPassword = new StringBuilder();

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 2).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);
            sbForgetPassword.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[code]", mMstUsers.EmailActivationCode).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbForgetPassword.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();
        }


        private void RequestItem(MstUsers mMstUsers)
        {
            StringBuilder sbRequestItem = new StringBuilder();

            //Check how to obtain Users Title
            // sbRequestItem.Append(objMailFormat.MailBody.ToString().Replace("[name]", p_objEmailData.UserName).Replace("[Title]", p_objEmailData.strData));

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 6).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);

            //Get title
            //sbRequestItem.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[Title]", mMstUsers.Title).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbRequestItem.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();
        }

        //**********************
        //private static StringBuilder BusinessRequest(PL_EmailInfo p_objEmailData)
        //{
        //    StringBuilder sbBusinessRequest = new StringBuilder();

        //    objMailFormat.MailTypeID = 9;

        //    objMailFormat = objBLMailFormat.BL_fnGetMailBodyText(objMailFormat);
        //    sbBusinessRequest.Append(objMailFormat.MailBody.ToString().Replace("[name]", p_objEmailData.UserName).Replace("[CompanyName]", p_objEmailData.strCommentingCompany).Replace("[Category]", p_objEmailData.strCategory).Replace("[RequestTitle]", p_objEmailData.strData).Replace("[RequestDetails]", p_objEmailData.strDescription).Replace("[RequestDate]", p_objEmailData.strRequestDate)).Replace("[RequestingMobile]", p_objEmailData.strRequestingMobile).Replace("[RequestingEmail]", p_objEmailData.strRequestingEmail);

        //    return sbBusinessRequest;
        //}
        


        //private static StringBuilder BusinessComment(PL_EmailInfo p_objEmailData)
        //{
        //    StringBuilder sbBusinessComment = new StringBuilder();

        //    objMailFormat.MailTypeID = 7;

        //    objMailFormat = objBLMailFormat.BL_fnGetMailBodyText(objMailFormat);
        //    sbBusinessComment.Append(objMailFormat.MailBody.ToString().Replace("[name]", p_objEmailData.UserName).Replace("[CompanyName]", p_objEmailData.strCommentingCompany).Replace("[Title]", p_objEmailData.strData));

        //    return sbBusinessComment;
        //}
        //**********************

        private void SeekerComment(MstUsers mMstUsers)
        {
            StringBuilder sbSeekerComment = new StringBuilder();

            //Get title
            // sbSeekerComment.Append(objMailFormat.MailBody.ToString().Replace("[name]", p_objEmailData.UserName).Replace("[Title]", p_objEmailData.strData));

            mMailType = db.MstMailType.Where(u => u.MailTypeId == 10).FirstOrDefault();
            //mMailType = db.MstMailType.Find(1);
            sbSeekerComment.Append(mMailType.MailBody.ToString().Replace("[name]", mMstUsers.UserName).Replace("[code]", mMstUsers.EmailActivationCode).Replace("[SiteURL]", "www.EzyFind.co.za"));

            string sbBody = AddImagePath(sbSeekerComment.ToString());

            MstEmailStack mMstEmailStack = new MstEmailStack()
            {
                ToName = mMstUsers.FirstName + " " + mMstUsers.LastName,
                ToAddress = mMstUsers.Email,
                Subject = "Registration confirmed",
                Body = sbBody,
                EmailCreatedOn = DateTime.Now,
                EmailSendCount = 0,
                EmailSentFrom = "Service",
                FromAddress = "support@ezyfind.co.za",
                EmailSentSuccess = false,
                AttachmentPath = null
            };

            db.MstEmailStack.Add(mMstEmailStack);
            db.SaveChangesAsync();
        }



    }
    }