import React from 'react';
import { Route, BrowserRouter, Switch } from 'react-router-dom';
import '../assets/img/favicon.png';
import '../assets/scss/bootstrap.min.css';
import '../assets/scss/fontawesome.css';
import '../assets/scss/style.css';
import '../assets/scss/athena.css';

import '../assets/scss/owl/owl.carousel.css';
import '../assets/scss/owl/owl.theme.css';
import '../assets/scss/selectric.css';
import '../assets/plugins/masterslider/style/masterslider.css';
import '../assets/plugins/masterslider/skins/default/style.css';

import routes from '../routes';

import Header from '../components/Header.js'
import Footer from '../components/Footer.js'
import ChatBox from '../components/ChatBox.js'

class Athena extends React.Component {

  loading = () => <div className="animated fadeIn pt-1 text-center">Loading...</div>

  render() {
    return (
      <div> 
        <Header/>           
        <BrowserRouter>
          <Switch>
            {routes.map((route, idx) => {
              return route.component ? (
                <Route
                  key={idx}
                  path={route.path}
                  exact={route.exact}
                  name={route.name}
                  render={props => (
                    <route.component {...props} />
                  )} />
              ) : (null);
            })}
          </Switch>
        </BrowserRouter>          
        <Footer />
        <ChatBox/>
      </div>
    );
  }
}

export default Athena;
