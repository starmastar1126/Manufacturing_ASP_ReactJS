import {
  container
} from "assets/jss/material-dashboard-pro-react.jsx";

const manufacturingCompaniesPageStyle = theme => ({
  container: {
    ...container,
    marginTop: "50px",
    zIndex: "4",
    // position: "absolute",
    [theme.breakpoints.down("sm")]: {
      paddingBottom: "100px"
    }
  },
  naviCenter: {
    textAlign: "center"
  }
});

export default manufacturingCompaniesPageStyle;
