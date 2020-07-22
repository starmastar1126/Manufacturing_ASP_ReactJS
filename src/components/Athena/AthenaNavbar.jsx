import React from "react";
import cx from "classnames";
import PropTypes from "prop-types";
import { NavLink } from "react-router-dom";
import SweetAlert from "react-bootstrap-sweetalert";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";
import AppBar from "@material-ui/core/AppBar";
import Toolbar from "@material-ui/core/Toolbar";
import Hidden from "@material-ui/core/Hidden";
import Drawer from "@material-ui/core/Drawer";
import List from "@material-ui/core/List";
import ListItem from "@material-ui/core/ListItem";
import ListItemText from "@material-ui/core/ListItemText";

// @material-ui/icons
import Dashboard from "@material-ui/icons/Dashboard";
import Menu from "@material-ui/icons/Menu";
import PersonAdd from "@material-ui/icons/PersonAdd";
import Fingerprint from "@material-ui/icons/Fingerprint";

// core components

import athenaNavbarStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaNavbarStyle.jsx";
import sweetAlertStyle from "assets/jss/material-dashboard-pro-react/views/sweetAlertStyle.jsx";

// Athena Customize
import logo from "assets/img/logo.png"
import Button from "components/CustomButtons/Button.jsx";
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";
import Heading from "components/Heading/Heading.jsx";

import avatar from "assets/img/faces/avatar.jpg";
import CustomInput from "components/CustomInput/CustomInput.jsx";
import Card from "components/Card/Card.jsx";
import CardBody from "components/Card/CardBody.jsx";
import CardAvatar from "components/Card/CardAvatar.jsx";
import CardFooter from "components/Card/CardFooter.jsx";

class AthenaNavbar extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      alert: null,
      show: false,
      open: false,
    };
    this.hideAlert = this.hideAlert.bind(this);
  }
  handleDrawerToggle = () => {
    this.setState({ open: !this.state.open });
  };
  // verifies if routeName is the one active (in browser input)
  activeRoute(routeName) {
    return this.props.location.pathname.indexOf(routeName) > -1 ? true : false;
  }  
  componentDidUpdate(e) {
    if (e.history.location.pathname !== e.location.pathname) {
      this.setState({ open: false });
    }
  }
  titleAndTextAlert() {
    this.setState({
      alert: (    
        <GridContainer>
          <GridItem xs={12} sm={3} md={3} lg={3}>
            <SweetAlert
              style={{ display: "block", marginTop: "-200px", paddingTop: "10px" }}
              onConfirm={() => this.hideAlert()}
              showConfirm={false}
            >
              <CardAvatar profile className={this.props.classes.cardAvatar}>
                <a href="#pablo" onClick={() => this.hideAlert()}>
                  <img src={avatar} alt="..." />
                </a>
              </CardAvatar>
              <CardBody profile>
                  <h4 className={this.props.classes.cardTitle}>Register as</h4>
                  <hr className={this.props.classes.hr1}/>
                  <Button href="/athena/list-your-business-page" color="rose" round>
                    Register as Business User
                  </Button>
                  <Button href="/athena/registration-page" color="rose" round>
                    &nbsp;&nbsp;&nbsp;Register&nbsp;&nbsp;as&nbsp;&nbsp;Individual&nbsp;&nbsp;&nbsp;
                  </Button>
              </CardBody>
            </SweetAlert>
          </GridItem>
        </GridContainer>
      )
    });
  }
  titleAndTextAlertApp() {
    this.setState({
      alert: (    
        <GridContainer>
          <GridItem xs={12} sm={3} md={3} lg={3}>
            <SweetAlert
              style={{ display: "block", marginTop: "-100px", paddingTop: "10px" }}
              onConfirm={() => this.hideAlert()}
              showConfirm={false}
            >
              <CardAvatar profile className={this.props.classes.cardAvatar}>
                <a href="#pablo" onClick={() => this.hideAlert()}>
                  <img src={avatar} alt="..." />
                </a>
              </CardAvatar>
              <CardBody profile>
                  <h4 className={this.props.classes.cardTitle}>Register as</h4>
                  <Button color="rose" round>
                    Register as Business User
                  </Button>
                  <Button color="rose" round>
                    &nbsp;&nbsp;&nbsp;Register&nbsp;&nbsp;as&nbsp;&nbsp;Individual&nbsp;&nbsp;&nbsp;
                  </Button>
              </CardBody>
            </SweetAlert>
          </GridItem>
        </GridContainer>
      ),
      open: false
    });
  }
  hideAlert() {
    this.setState({
      alert: null
    });
  }

  render() {
    const { classes, color, brandText } = this.props;
    const appBarClasses = cx({
      [" " + classes[color]]: color
    });

    var list = (
      <List className={classes.list}>
        <ListItem className={classes.listItem}>
          <NavLink to={"/athena/home-page"}
            className={cx(classes.navLink, {
              [classes.navLinkActive]: this.activeRoute("/athena/home-page")
            })}
          >
            <ListItemText
              primary={"HOME"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        {/* <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/products-page"}
            className={cx(classes.navLink, {
              [classes.navLinkActive]: this.activeRoute("/athena/products-page")
            })}
          >
            <ListItemText
              primary={"PRODUCTS"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem> */}
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/manufacturing-companies-page"}
            className={cx(classes.navLink, {
              [classes.navLinkActive]: this.activeRoute("/athena/manufacturing-companies-page")
            })}
          >
            <ListItemText
              primary={"MANUFACTURING COMPANIES"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/digital-catalogues-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/disital-catalogues-page")})}
          >
            <ListItemText
              primary={"DIGITAL CATALOGUES"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/specials-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/specials-page")})}
          >
            <ListItemText
              primary={"SPECIALS"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/list-your-business-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/list-your-business-page")})}
          >
            <ListItemText
              primary={"LIST YOUR BUSINESS"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        {/* <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/jobs-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/jobs-page")})}
          >
            <ListItemText
              primary={"JOBS"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem> */}
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/contact-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/contact-page")})}
          >
            <ListItemText
              primary={"CONTACT"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/about-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/about-page")})}
          >
            <ListItemText
              primary={"ABOUT"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem>
        {/* <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/career-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/career-page")})}
          >
            <ListItemText
              primary={"CAREER"}
              disableTypography={true}
              className={classes.athenaListItemText}
            />
          </NavLink>
        </ListItem> */}
      </List>
    );
    var leftlist = (
      <List className={classes.list}>
        <ListItem className={classes.listItem}>
          <Button href="https://itunes.apple.com/us/app/ezyfind/id980233151?ls=1&mt=8" className={`${classes.athenaNavLink}`}>
            iPHONE
          </Button>
          {/* <NavLink to={"/athena/iphone-page"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/athena/iphone-page")})}
          >
            <ListItemText
              primary={"iPHONE"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <Button href="https://play.google.com/store/apps/details?id=com.INNOVEzyFind" className={`${classes.athenaNavLink}`}>
            ANDROID
          </Button>
          {/* <NavLink
            to={"/athena/android-page"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/athena/android-page")})}
          >
            <ListItemText
              primary={"ANDROID"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <Button href="http://www.windowsphone.com/en-in/store/app/ezyfind/6d32b44b-cdb4-4404-8f4d-09542a33934f" className={`${classes.athenaNavLink}`}>
            WINDOWS
          </Button>
          {/* <NavLink
            to={"/athena/windows-page"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/athena/windows-page")})}
          >
            <ListItemText
              primary={"WINDOWS"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
      </List>
    );
    var rightlist = (
      <List className={classes.list}>
        {/* <ListItem className={classes.listItem}>
          <NavLink
            to={"/admin/dashboard"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/admin/dashboard")})}
          >
            <Dashboard className={classes.listItemIcon} />
            <ListItemText
              primary={"DASHBOARD"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink>
        </ListItem> */}
        <ListItem className={classes.listItem}>
          <Button className={classes.athenaNavLink} onClick={this.titleAndTextAlert.bind(this)}>
            <PersonAdd className={classes.listItemIcon} /> REGISTER
          </Button>
          {/* <NavLink
            to={"/athena/register-page"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/athena/register-page")})}
          >
            <PersonAdd className={classes.listItemIcon} />
            <ListItemText
              primary={"REGISTER"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/login-page"}
            className={cx(classes.athenaNavLink, {[classes.navLinkActive]: this.activeRoute("/athena/login-page")})}
          >
            <Fingerprint className={classes.listItemIcon} />
            <ListItemText
              primary={"LOGIN"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink>
        </ListItem>
      </List>
    );
    var applist = (
      <List className={classes.list}>
        <ListItem className={classes.listItem}>
          <Button href="https://itunes.apple.com/us/app/ezyfind/id980233151?ls=1&mt=8" className={`${classes.athenaAppLink}`}>
            iPHONE
          </Button>
          {/* <NavLink to={"/athena/iphone-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/iphone-page")})}
          >
            <ListItemText
              primary={"iPHONE"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <Button href="https://play.google.com/store/apps/details?id=com.INNOVEzyFind" className={`${classes.athenaAppLink}`}>
            ANDROID
          </Button>
          {/* <NavLink
            to={"/athena/android-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/android-page")})}
          >
            <ListItemText
              primary={"ANDROID"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <Button href="http://www.windowsphone.com/en-in/store/app/ezyfind/6d32b44b-cdb4-4404-8f4d-09542a33934f" className={`${classes.athenaAppLink}`}>
            WINDOWS
          </Button>
          {/* <NavLink
            to={"/athena/windows-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/windows-page")})}
          >
            <ListItemText
              primary={"WINDOWS"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        {/* <ListItem className={classes.listItem}>
          <NavLink
            to={"/admin/dashboard"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/admin/dashboard")})}
          >
            <ListItemText
              primary={"DASHBOARD"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink>
        </ListItem> */}
        <ListItem className={classes.listItem}>
          <Button href="#" className={`${classes.athenaAppLink}`} onClick={this.titleAndTextAlertApp.bind(this)}>
            REGISTER
          </Button>
          {/* <NavLink
            to={"/athena/register-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/register-page")})}
          >
            <ListItemText
              primary={"REGISTER"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink> */}
        </ListItem>
        <ListItem className={classes.listItem}>
          <NavLink
            to={"/athena/login-page"}
            className={cx(classes.navLink, {[classes.navLinkActive]: this.activeRoute("/athena/login-page")})}
          >
            <ListItemText
              primary={"LOGIN"}
              disableTypography={true}
              className={classes.listItemText}
            />
          </NavLink>
        </ListItem>
      </List>
    );
    // var mainlist = (
    //   <List>
    //     <ListItem>
    //       <GridContainer><GridItem xs={12} sm={12} md={12}/></GridContainer>
    //     </ListItem>
    //   </List>
    // );
    return (
      <AppBar position="static" className={classes.appBar + appBarClasses}>
        <div className={classes.containerDiv}>
        {this.state.alert}
        <Toolbar className={classes.container}>
          <GridContainer direction="row" justify="center" alignItems="flex-start">
            <GridItem xs={12} md={2}>
              <div className={classes.athenaBlank}>EZYFIND Apps for</div>
            </GridItem>
            <GridItem xs={12} md={7}>
              <Hidden smDown>{leftlist}</Hidden>
            </GridItem>
            <GridItem xs={12} md={3}>
              <Hidden smDown>{rightlist}</Hidden>
            </GridItem>
          </GridContainer>
        </Toolbar>
        </div>
        <div className={classes.athenaContainerDiv}>
        <Toolbar className={classes.athenaContainer}>
              <Hidden smDown>
          <GridContainer direction="row" justify="space-evenly" alignItems="center">
            <GridItem md={2}>
              <Hidden smDown>
                <div className={classes.flex}>
                  <Button href="#" className={classes.title} color="transparent">
                    <img src={logo} alt="..." />
                  </Button>
                </div>
              </Hidden>
            </GridItem>
            <GridItem md={10}>
              <Hidden smDown>
                  {list}
              </Hidden>
            </GridItem>
          </GridContainer>
              </Hidden>
          <Hidden mdUp>
            <GridContainer direction="row" justify="flex-between" alignItems="strech">
              <GridItem xs={3}>
                <img className={classes.athenaSmallLogo} src={logo} alt="..." />
              </GridItem>
              <GridItem xs={7}/>
              <GridItem xs={1}>
                <Button
                  className={classes.sidebarButton}
                  color="transparent"
                  justIcon
                  aria-label="open drawer"
                  onClick={this.handleDrawerToggle}
                >
                  <Menu />
                </Button>
              </GridItem>
            </GridContainer>
          </Hidden>
          <Hidden mdUp>
            <Hidden mdUp>
              <Drawer
                variant="temporary"
                anchor={"right"}
                open={this.state.open}
                classes={{paper: classes.drawerPaper}}
                onClose={this.handleDrawerToggle}
                ModalProps={{keepMounted: true}}
              >
                {list}{applist}
              </Drawer>
            </Hidden>
          </Hidden>
        </Toolbar>
        </div>
      </AppBar>
    );
  }
}

AthenaNavbar.propTypes = {
  classes: PropTypes.object.isRequired,
  color: PropTypes.oneOf(["primary", "info", "success", "warning", "danger"]),
  brandText: PropTypes.string
};

export default withStyles(athenaNavbarStyle)(AthenaNavbar);
