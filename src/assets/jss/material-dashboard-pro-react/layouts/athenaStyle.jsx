import {
  whiteColor,
  blackColor,
  hexToRgb
} from "assets/jss/material-dashboard-pro-react.jsx";

const athenaStyle = theme => ({
  wrapper: {
    height: "auto",
    minHeight: "100vh",
    position: "relative",
    top: "0"
  },
  fullPage: {
    padding: "130px 0 0 0",
    position: "relative",
    minHeight: "100vh",
    display: "flex!important",
    margin: "0",
    border: "0",
    color: whiteColor,
    alignItems: "center",
    backgroundSize: "cover",
    backgroundPosition: "center center",
    height: "100%",
    [theme.breakpoints.down("sm")]: {
      minHeight: "fit-content!important"
    },
    "& footer": {
      position: "absolute",
      bottom: "0",
      width: "100%",
      border: "none !important"
    },
    "&:before": {
      backgroundColor: "rgba(" + hexToRgb(blackColor) + ", 0.1)"
    },
    "&:before,&:after": {
      display: "block",
      content: '""',
      position: "absolute",
      width: "100%",
      height: "100%",
      top: "0",
      left: "0",
      zIndex: "2"
    }
  },
  // note: {
  //   fontFamily: '"Roboto", "Helvetica", "Arial", sans-serif',
  //   bottom: "5px",
  //   color: "#ffffff",
  //   display: "block",
  //   fontWeight: "400",
  //   fontSize: "13px",
  //   lineHeight: "35px",
  //   left: "0",
  //   marginLeft: "10px",
  //   width: "100%"
  // }
});

export default athenaStyle;
