import React from "react";
import ReactDOM from "react-dom";
import { createBrowserHistory } from "history";
import { Router, Route, Switch, Redirect } from "react-router-dom";

import AuthLayout from "layouts/Auth.jsx";
import RtlLayout from "layouts/RTL.jsx";
import AdminLayout from "layouts/Admin.jsx";
// Athena Customize
import AthenaLayout from "layouts/Athena.jsx";
import '@fortawesome/fontawesome-free/css/all.min.css';
import 'bootstrap-css-only/css/bootstrap.min.css';
import 'mdbreact/dist/css/mdb.css';

import "assets/scss/material-dashboard-pro-react.scss?v=1.5.0";

const hist = createBrowserHistory();

ReactDOM.render(
  <Router history={hist}>
    <Switch>
      <Route path="/rtl" component={RtlLayout} />
      <Route path="/auth" component={AuthLayout} />
      <Route path="/admin" component={AdminLayout} />
      <Route path="/athena" component={AthenaLayout} />
      {/* <Redirect from="/" to="/admin/dashboard" /> */}
      <Redirect from="/" to="/athena/home-page" />
    </Switch>
  </Router>,
  document.getElementById("root")
);
