import React from "react";
import PropTypes from "prop-types";
import { Switch, Route } from "react-router-dom";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components -- Athena Customize
import AthenaNavbar from "components/Athena/AthenaNavbar.jsx";
import AthenaFooter from "components/Athena/AthenaFooter.jsx";

import routes from "routes.js";
// Athena Customize
import athenaStyle from "assets/jss/material-dashboard-pro-react/layouts/athenaStyle.jsx";

import background from "assets/img/background.jpeg";
import register from "assets/img/register.jpeg";
import login from "assets/img/login.jpeg";
import lock from "assets/img/lock.jpeg";
import error from "assets/img/clint-mckoy.jpg";
import pricing from "assets/img/bg-pricing.jpeg";
// import home from "assets/img/bg-home.jpg";
// import products from "assets/img/bg-products.jpeg";
// import manufacturingCompanies from "assets/img/bg-manufacturing-companies.jpg";

class Athena extends React.Component {
  componentDidMount() {
    document.body.style.overflow = "unset";
  }
  getRoutes = routes => {
    return routes.map((prop, key) => {
      if (prop.collapse) {
        return this.getRoutes(prop.views);
      }
      if (prop.layout === "/athena") {
        return (
          <Route
            path={prop.layout + prop.path}
            component={prop.component}
            key={key}
          />
        );
      } else {
        return null;
      }
    });
  };
  getBgImage = () => {
    if (window.location.pathname.indexOf("/athena/register-page") !== -1) {
      return register;
    } else if (window.location.pathname.indexOf("/athena/login-page") !== -1) {
      return login;
    } else if (window.location.pathname.indexOf("/athena/pricing-page") !== -1) {
      return pricing;
    // } else if (window.location.pathname.indexOf("/athena/home-page") !== -1) {
    //   return background;
    // } else if (window.location.pathname.indexOf("/athena/products-page") !== -1) {
    //   return background;
    // } else if (window.location.pathname.indexOf("/athena/manufacturing-companies-page") !== -1) {
    //   return background;
    // } else if (window.location.pathname.indexOf("/athena/digital-catalogues-page") !== -1) {
    //   return background;
    } else if (window.location.pathname.indexOf("/athena/lock-screen-page") !== -1) {
      return lock;
    } else if (window.location.pathname.indexOf("/athena/error-page") !== -1) {
      return error;
    }
  };
  getActiveRoute = routes => {
    let activeRoute = "Default Brand Text";
    for (let i = 0; i < routes.length; i++) {
      if (routes[i].collapse) {
        let collapseActiveRoute = this.getActiveRoute(routes[i].views);
        if (collapseActiveRoute !== activeRoute) {
          return collapseActiveRoute;
        }
      } else {
        if (
          window.location.href.indexOf(routes[i].layout + routes[i].path) !== -1
        ) {
          return routes[i].name;
        }
      }
    }
    return activeRoute;
  };
  render() {
    const { classes, ...rest } = this.props;
    return (
      <div>
        <AthenaNavbar brandText={this.getActiveRoute(routes)} {...rest} />
        <div className={classes.wrapper} ref="wrapper">
          <div className={classes.fullPage} style={{ backgroundImage: "url(" + this.getBgImage() + ")" }}>
            <Switch>{this.getRoutes(routes)}</Switch>
          </div>
        </div>
        <AthenaFooter white />
      </div>
    );
  }
}

Athena.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(athenaStyle)(Athena);
