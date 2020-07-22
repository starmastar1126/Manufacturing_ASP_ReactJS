import React from "react";
import PropTypes from "prop-types";
import cx from "classnames";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";

import athenaFooterStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaFooterStyle";

// Athena Customize
import Button from "components/CustomButtons/Button.jsx";
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";
import iosIcon from "assets/img/ios.png";
import winIcon from "assets/img/win.png";
import androidIcon from "assets/img/android.png";

function AthenaFooter({ ...props }) {
  const { classes, fluid, white, rtlActive } = props;
  var container = cx({
    [classes.container]: !fluid,
    [classes.containerFluid]: fluid,
    [classes.whiteColor]: white
  });
  var athenaContainer = cx({
    [classes.athenaContainer]: !fluid,
    [classes.containerFluid]: fluid,
    [classes.whiteColor]: white
  });
  var anchor =
    classes.a +
    cx({
      [" " + classes.whiteColor]: white
    });
  var block = cx({
    [classes.block]: true,
    [classes.whiteColor]: white
  });
  var width100 = {
    width: "100%"
  }
  return (
    <footer className={classes.footer}>
    <div className={classes.athenaContainerDiv}>
      <div className={athenaContainer}>
        <GridContainer direction="row" justify="space-around" alignItems="flex-start">
            <GridItem xs={12} md={3}>
              <div className={classes.leftAlign}>
                <p className={`${classes.boldFont} ${classes.whiteColor}`}>QUICK LINKS</p>
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;24/7 Support
                  </a>
                </p>
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;Features
                  </a>
                </p>
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;About Us
                  </a>
                </p>
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;Individual Terms & Conditions
                  </a>
                </p> 
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;Business Terms & Conditions
                  </a>
                </p> 
                <p className={`${classes.font13}`}>
                  <a href="#" className={`${classes.underLine} ${classes.whiteColor}`}>
                  >&nbsp;&nbsp;&nbsp;Privacy Policy
                  </a>
                </p> 
              </div>
            </GridItem>
            <GridItem xs={12} md={3}>
              <div className={classes.leftAlign}>
                <p className={`${classes.boldFont} ${classes.whiterColor}`}>GET IN TOUCH</p>
              </div>
              <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                <GridItem md={1}>
                  <i className="fa fa-comment"></i>
                </GridItem>
                <GridItem md={8}>
                  <div className={classes.leftAlign}>
                    <p><font className={classes.font15}>Need help?</font><br/>
                    <a href="#" className={`${classes.font13} ${classes.whiteColor}`}>24/7 Support online chat</a></p>
                  </div>
                </GridItem>
              </GridContainer> 
              <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                <GridItem md={1}>
                  <i className="fa fa-phone"></i>
                </GridItem>
                <GridItem md={8}>
                  <div className={classes.leftAlign}>
                    <p className={`${classes.font15} ${classes.whiterColor}`}><strong>Phone:</strong>&nbsp;011 056 9123 </p>
                  </div>
                </GridItem>
               </GridContainer> 
               <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                <GridItem md={1}>
                  <i className="fa fa-envelope"></i>
                </GridItem>
                <GridItem md={8}>
                  <div className={classes.leftAlign}>
                    <p><font className={classes.font15}><strong>Email:</strong></font><br/>
                    <a href="#" className={`${classes.font13} ${classes.whiteColor}`}>info@ezyfind.co.za</a></p>
                  </div>
                </GridItem>
              </GridContainer> 
            </GridItem>
            <GridItem xs={12} md={2}>
              <div className={classes.leftAlign}>
                <p className={`${classes.boldFont} ${classes.whiterColor}`}>DOWNLOAD APPS</p>
              </div> 
              <div className={classes.leftAlign}>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={2}>
                      <img src={iosIcon} className={classes.imageSize}></img>
                    </GridItem>
                    <GridItem md={8}>
                      &nbsp;&nbsp;<a className="fb-ic mr-3" role="button">iOS App Store</a>
                    </GridItem>
                  </GridContainer> 
                </p>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={2}>
                      <img src={androidIcon} className={classes.imageSize}></img>
                    </GridItem>
                    <GridItem md={8}>
                      &nbsp;&nbsp;<a className="gplus-ic mr-3" role="button">Android Store</a>
                    </GridItem>
                  </GridContainer> 
                </p>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={2}>
                      <img src={winIcon} className={classes.imageSize}></img>
                    </GridItem>
                    <GridItem md={10}>
                      &nbsp;&nbsp;<a className="fb-ic mr-3" role="button">Windows Store</a>
                    </GridItem>
                  </GridContainer> 
                </p>
              </div>
            </GridItem>
            <GridItem xs={12} md={2}>
              <div className={classes.leftAlign}>
                <p className={`${classes.boldFont} ${classes.whiterColor}`}>FOLLOW US</p>
              </div> 
              <div className={classes.leftAlign}>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={1}>
                    <i class="fab fa-lg fa-facebook-f"></i>
                    </GridItem>
                    <GridItem md={8}>
                      &nbsp;<a className="fb-ic mr-3" role="button">Facebook</a>
                    </GridItem>
                  </GridContainer> 
                </p>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={1}>
                      <i className="fab fa-lg fa-google-plus-g"></i>
                    </GridItem>
                    <GridItem md={8}>
                      &nbsp;<a className="gplus-ic mr-3" role="button">Google+</a>
                    </GridItem>
                  </GridContainer> 
                </p>
                <p className={`${classes.font15} ${classes.height30} ${classes.middle}`}>
                  <GridContainer direction="row" justify="flex-start" alignItems="flex-start">
                    <GridItem md={1}>
                      <i className="fab fa-lg fa-twitter"></i>
                    </GridItem>
                    <GridItem md={8}>
                      &nbsp;<a className="fb-ic mr-3" role="button">Twitter</a>
                    </GridItem>
                  </GridContainer> 
                </p>
              </div>
            </GridItem>
        </GridContainer>
      </div>
      </div>
      <div className={classes.containerDiv}>
      <div className={container}>
        <p className={classes.athenaTitle}>
          &copy; {1900 + new Date().getYear()}{" "}
          © 2019 www.ManufacturingEzyFind.co.za    All Rights Reserved. Registered under Innovation Evolved (Pty) Ltd<br/>
          www.ManufacturingEzyFind.co.za is not responsible for any loss incurred whatsoever by using this services.
        </p>
      </div>
      </div>
    </footer>
  );
}

AthenaFooter.propTypes = {
  classes: PropTypes.object.isRequired,
  fluid: PropTypes.bool,
  white: PropTypes.bool,
  rtlActive: PropTypes.bool
};

export default withStyles(athenaFooterStyle)(AthenaFooter);
