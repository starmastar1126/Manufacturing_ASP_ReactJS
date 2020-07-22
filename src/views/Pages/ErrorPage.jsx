import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";

import errorPageStyles from "assets/jss/material-dashboard-pro-react/views/errorPageStyles.jsx";

class ErrorPage extends React.Component {
  render() {
    const { classes } = this.props;
    return (
      <div className={classes.contentCenter}>
        <GridContainer>
          <GridItem md={12}>
            <h1 className={classes.title}>404</h1>
            <h2 className={classes.subTitle}>Page not found :(</h2>
            <h4 className={classes.description}>
              Ooooups! Looks like you got lost.
            </h4>
          </GridItem>
        </GridContainer>
      </div>
    );
  }
}

ErrorPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(errorPageStyles)(ErrorPage);
