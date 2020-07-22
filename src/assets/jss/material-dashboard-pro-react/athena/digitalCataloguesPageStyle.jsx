import {
  container
} from "assets/jss/material-dashboard-pro-react.jsx";

const digitalCataloguesPageStyle = theme => ({
  container: {
    ...container,
    marginTop: "50px",
    zIndex: "4",
    [theme.breakpoints.down("sm")]: {
      paddingBottom: "100px"
    }
  },
  naviCenter: {
    textAlign: "center"
  }
  
});

export default digitalCataloguesPageStyle;
