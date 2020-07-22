import {
  cardTitle,
  whiteColor
} from "assets/jss/material-dashboard-pro-react.jsx";
import customSelectStyle from "assets/jss/material-dashboard-pro-react/customSelectStyle.jsx";
import hoverCardStyle from "assets/jss/material-dashboard-pro-react/hoverCardStyle.jsx";

const athenaSearchCardStyle = theme => ({
  ...customSelectStyle,
  ...hoverCardStyle,
  cardTitleWhite: {
    ...cardTitle,
    color: whiteColor + " !important"
  },
});

export default athenaSearchCardStyle;
