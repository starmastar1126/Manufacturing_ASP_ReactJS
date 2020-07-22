import {
  primaryColor,
  dangerColor,
  successColor,
  roseColor,
  infoColor,
  warningColor,
  whiteColor,
  blackColor,
  grayColor,
  hexToRgb
} from "assets/jss/material-dashboard-pro-react.jsx";

const wizardStyle = {
  wizardContainer: {},
  card: {
    display: "inline-block",
    position: "relative",
    width: "100%",
    margin: "25px 0",
    boxShadow: "0 1px 4px 0 rgba(" + hexToRgb(blackColor) + ", 0.14)",
    borderRadius: "6px",
    color: "rgba(" + hexToRgb(blackColor) + ", 0.87)",
    background: whiteColor,
    transition: "all 300ms linear",
    minHeight: "410px"
  },
  wizardHeader: {
    textAlign: "center",
    padding: "25px 0 35px"
  },
  title: {
    margin: "0"
  },
  subtitle: {
    margin: "5px 0 0"
  },
  wizardNavigation: {
    position: "relative"
  },
  nav: {
    marginTop: "20px",
    paddingLeft: "0",
    marginBottom: "0",
    listStyle: "none",
    backgroundColor: "rgba(" + hexToRgb(grayColor[17]) + ", 0.2)",
    "&:after,&:before": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      boxSizing: "border-box"
    }
  },
  steps: {
    marginLeft: "0",
    textAlign: "center",
    // float: "left",
    // display: "block",
    position: "relative",
    display: "inline-block"
  },
  stepsAnchor: {
    cursor: "pointer",
    position: "relative",
    display: "block",
    padding: "10px 15px",
    textDecoration: "none",
    transition: "all .3s",
    border: "0 !important",
    borderRadius: "30px",
    lineHeight: "18px",
    textTransform: "uppercase",
    fontSize: "12px",
    fontWeight: "500",
    minWidth: "100px",
    textAlign: "center",
    color: grayColor[6] + " !important"
  },
  content: {
    marginTop: "20px",
    minHeight: "340px",
    padding: "20px 15px"
  },
  stepContent: {
    display: "none"
  },
  stepContentActive: {
    display: "block"
  },
  movingTab: {
    position: "absolute",
    textAlign: "center",
    padding: "12px",
    fontSize: "12px",
    textTransform: "uppercase",
    WebkitFontSmoothing: "subpixel-antialiased",
    top: "-4px",
    left: "0px",
    borderRadius: "4px",
    color: whiteColor,
    cursor: "pointer",
    fontWeight: "500"
  },
  primary: {
    backgroundColor: primaryColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(primaryColor[0]) +
      ", 0.4)"
  },
  warning: {
    backgroundColor: warningColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(warningColor[0]) +
      ", 0.4)"
  },
  danger: {
    backgroundColor: dangerColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(dangerColor[0]) +
      ", 0.4)"
  },
  success: {
    backgroundColor: successColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(successColor[0]) +
      ", 0.4)"
  },
  info: {
    backgroundColor: infoColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(infoColor[0]) +
      ", 0.4)"
  },
  rose: {
    backgroundColor: roseColor[0],
    boxShadow:
      "0 4px 20px 0px rgba(" +
      hexToRgb(blackColor) +
      ", 0.14), 0 7px 10px -5px rgba(" +
      hexToRgb(roseColor[0]) +
      ", 0.4)"
  },
  footer: {
    padding: "0 15px"
  },
  left: {
    float: "left!important"
  },
  right: {
    float: "right!important"
  },
  clearfix: {
    "&:after,&:before": {
      display: "table",
      content: '" "'
    },
    clear: "both"
  }
};

export default wizardStyle;
