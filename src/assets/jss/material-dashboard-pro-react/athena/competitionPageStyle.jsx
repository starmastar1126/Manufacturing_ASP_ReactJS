import {
  container,
  defaultFont,
  cardTitle,
  roseColor,
  whiteColor,
  grayColor,
  hexToRgb
} from "assets/jss/material-dashboard-pro-react.jsx";
import customSelectStyle from "assets/jss/material-dashboard-pro-react/customSelectStyle.jsx";

const competitionPageStyle = theme => ({
  ...customSelectStyle,
  // ...hoverCardStyle,
  container: {
    ...container,
    marginTop: "50px",
    zIndex: "4",
    [theme.breakpoints.down("sm")]: {
      paddingBottom: "100px"
    }
  },
  content2: {
    color: "#222",
    fontSize: "20px",
    lineHeight: "28px",
    fontWeight: "600",
    paddingBottom: "10px",
    textAlign: "center",
    fontFamily: "Open Sans, sans-serif"
  },
  content3: {
    fontSize: "15px",
    fontWeight: "400",
    color: "#555",
    margin: "10px 0 10px 0"
  },
  content4: {
    fontSize: "15px",
    fontWeight: "400",
    color: "#555",
    margin: "10px 0 5px 50px"
  },
  headline: {
    fontSize: "14px",
    fontWeight: "800",
    padding: "20px 10px 0  0",
    fontFamily: "Raleway",
    textTransform: "uppercase",
    letterSpacing: "3px"
  },
  hr1: {
    marginTop: "20px",
    marginBottom: "20px",
    border: "0",
    borderTop: "1px solid #eee"
  },
  contactTitle: {
    // color: "#CD2323",
    fontSize: "30px",
    fontWeight: "900",
    textAlign: "center",
  },
  
  list2: {
    fontFamily: "Open Sans, sans-serif",
    "li:before": {
      content: ">"
    }
  }
});

export default competitionPageStyle;
