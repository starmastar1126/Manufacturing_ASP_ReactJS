import {
  container,
  defaultFont,
  primaryColor,
  defaultBoxShadow,
  infoColor,
  successColor,
  warningColor,
  dangerColor,
  boxShadow,
  drawerWidth,
  transition,
  whiteColor,
  grayColor,
  blackColor,
  hexToRgb
} from "assets/jss/material-dashboard-pro-react.jsx";

const athenaNavbarStyle = theme => ({
  appBar: { // athena customize
    backgroundColor: "transparent",
    boxShadow: "none",
    borderBottom: "0",
    marginBottom: "0",
    position: "absolute",
    width: "100%",
    paddingTop: "0",
    zIndex: "1029",
    color: grayColor[6],
    border: "0",
    borderRadius: "3px",
    padding: "10px 0",
    transition: "all 150ms ease 0s",
    minHeight: "50px",
    display: "block"
  },
  container: {
    // ...container,
    paddingRight: "15px",
    paddingLeft: "15px",
    marginRight: "auto",
    marginLeft: "auto",
    "@media (min-width: 768px)": {
      width: "750px"
    },
    "@media (min-width: 992px)": {
      width: "970px"
    },
    "@media (min-width: 1200px)": {
      width: "1170px"
    },
    "&:before,&:after": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      clear: "both"
    },
    minHeight: "30px",
    // position: "fixed", // Athena Customize
    backgroundColor: 'rgb(150, 0, 0)',
    // top: "0px",
    // width: "100%",
    // zIndex: "100"
  },
  containerDiv: {
    // ...container,
    paddingRight: "15px",
    paddingLeft: "15px",
    marginRight: "auto",
    marginLeft: "auto",
    "@media (min-width: 768px)": {
      width: "100%"
    },
    "@media (min-width: 992px)": {
      width: "100%"
    },
    "@media (min-width: 1200px)": {
      width: "100%"
    },
    "&:before,&:after": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      clear: "both"
    },
    minHeight: "30px",
    // position: "fixed", // Athena Customize
    backgroundColor: 'rgb(150, 0, 0)',
    // top: "0px",
    // width: "100%",
    // zIndex: "100"
  },
  athenaContainerDiv: {
    // ...container,
    paddingRight: "15px",
    paddingLeft: "15px",
    marginRight: "auto",
    marginLeft: "auto",
    "@media (min-width: 768px)": {
      width: "100%"
    },
    "@media (min-width: 992px)": {
      width: "100%"
    },
    "@media (min-width: 1200px)": {
      width: "100%"
    },
    "&:before,&:after": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      clear: "both"
    },
    minHeight: "50px",
    // position: "fixed", // Athena Customize
    backgroundColor: '#221E1F',
    // top: "30px",
    // width: "100%",
    // zIndex: "100"
  },
  athenaContainer: {
    ...container,
    minHeight: "50px",
    // position: "fixed", // Athena Customize
    backgroundColor: '#221E1F',
    // top: "30px",
    // width: "100%",
    // zIndex: "100"
  },
  flex: {
    flex: 1
  },
  title: {
    ...defaultFont,
    lineHeight: "30px",
    fontSize: "18px",
    borderRadius: "3px",
    textTransform: "none",
    color: whiteColor,
    "&:hover,&:focus": {
      background: "transparent",
      color: whiteColor
    }
  },
  appResponsive: {
    top: "8px"
  },
  primary: {
    backgroundColor: primaryColor[0],
    color: whiteColor,
    ...defaultBoxShadow
  },
  info: {
    backgroundColor: infoColor[0],
    color: whiteColor,
    ...defaultBoxShadow
  },
  success: {
    backgroundColor: successColor[0],
    color: whiteColor,
    ...defaultBoxShadow
  },
  warning: {
    backgroundColor: warningColor[0],
    color: whiteColor,
    ...defaultBoxShadow
  },
  danger: {
    backgroundColor: dangerColor[0],
    color: whiteColor,
    ...defaultBoxShadow
  },
  list: {
    ...defaultFont,
    fontSize: "14px",
    margin: 0,
    marginRight: "-15px",
    paddingLeft: "0",
    listStyle: "none",
    color: whiteColor,
    paddingTop: "0",
    paddingBottom: "0"
  },
  listItem: {
    float: "left",
    position: "relative",
    display: "block",
    width: "auto",
    margin: "0",
    padding: "0",
    [theme.breakpoints.down("sm")]: {
      zIndex: "999",
      width: "100%",
      paddingRight: "15px"
    }
  },
  navLink: {  //athena customize
    color: whiteColor,
    margin: "0 3px",
    paddingTop: "5px",
    paddingBottom: "5px",
    fontWeight: "300",
    fontSize: "15px",
    textTransform: "uppercase",
    borderRadius: "3px",
    lineHeight: "20px",
    position: "relative",
    display: "block",
    padding: "5px 10px",
    textDecoration: "none",
    "&:hover,&:focus": {
      color: whiteColor,
      background: "rgba(" + hexToRgb(grayColor[17]) + ", 0.3)"
    }
  },
  athenaNavLink: {  //athena customize
    color: whiteColor,
    margin: "0 3px",
    paddingTop: "5px",
    paddingBottom: "5px",
    fontWeight: "500",
    fontSize: "13px",
    textTransform: "uppercase",
    borderRadius: "3px",
    lineHeight: "20px",
    position: "relative",
    display: "block",
    padding: "5px 10px",
    textDecoration: "none",
    background: "transparent",
    "&:hover,&:focus": {
      color: whiteColor,
      background: "rgba(" + hexToRgb(grayColor[17]) + ", 0.3)"
    }
  },
  athenaAppLink: {  //athena customize
    textAlign: "left",
    color: whiteColor,
    margin: "0 3px",
    paddingTop: "5px",
    paddingBottom: "5px",
    fontWeight: "500",
    fontSize: "15px",
    textTransform: "uppercase",
    borderRadius: "3px",
    lineHeight: "20px",
    position: "relative",
    display: "block",
    padding: "5px 10px",
    textDecoration: "none",
    background: "transparent",
    "&:hover,&:focus": {
      color: whiteColor,
      background: "rgba(" + hexToRgb(grayColor[17]) + ", 0.3)"
    }
  },
  blank: {  //athena customize
    color: whiteColor,
    height: "20px",
  },
  listItemIcon: {
    marginTop: "-3px",
    top: "0px",
    position: "relative",
    marginRight: "3px",
    width: "15px",
    height: "15px",
    verticalAlign: "middle",
    color: "inherit",
    display: "inline-block"
  },
  listItemText: {
    flex: "none",
    padding: "0",
    minWidth: "0",
    margin: 0,
    display: "inline-block",
    position: "relative",
    whiteSpace: "nowrap"
  },
  athenaListItemText: {
    // fontSize: "13px", //Athena customize
    fontWeight: "400", //Athena customize
    flex: "none",
    padding: "0",
    minWidth: "0",
    margin: 0,
    display: "inline-block",
    position: "relative",
    whiteSpace: "nowrap"
  },
  navLinkActive: {
    backgroundColor: "rgba(" + hexToRgb(whiteColor) + ", 0.3)"
  },
  drawerPaper: {
    border: "none",
    bottom: "0",
    transitionProperty: "top, bottom, width",
    transitionDuration: ".2s, .2s, .35s",
    transitionTimingFunction: "linear, linear, ease",
    ...boxShadow,
    width: drawerWidth,
    ...boxShadow,
    position: "fixed",
    display: "block",
    top: "0",
    height: "100vh",
    right: "0",
    left: "auto",
    visibility: "visible",
    overflowY: "visible",
    borderTop: "none",
    textAlign: "left",
    paddingRight: "0px",
    paddingLeft: "0",
    ...transition,
    "&:before,&:after": {
      position: "absolute",
      zIndex: "3",
      width: "100%",
      height: "100%",
      content: '""',
      display: "block",
      top: "0"
    },
    "&:after": {
      background: blackColor,
      opacity: ".8"
    }
  },
  sidebarButton: {
    "&,&:hover,&:focus": {
      color: whiteColor
    },
    top: "-2px"
  },
  athenaSmallLogo: {
    marginTop: "5px",
    width: "70px",
    height: "40px",
  },
  athenaBlank: {
    marginTop: "5px",
    textAlign: "right",
    color: whiteColor,
  },
  cardAvatar: {
    maxWidth: "90px",
    maxHeight: "90px",
    marginTop: "5px",
  },
  hr1: {
    marginTop: "20px",
    marginBottom: "20px",
    border: "0",
    borderTop: "1px solid #eee"
  },
});

export default athenaNavbarStyle;
