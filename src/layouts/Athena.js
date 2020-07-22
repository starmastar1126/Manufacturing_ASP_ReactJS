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

import Header from '../components/Header.js';
import Footer from '../components/Footer.js';
// import ChatBox from '../components/ChatBox.js';

class Athena extends React.Component {

  loading = () => <div className="animated fadeIn pt-1 text-center">Loading...</div>

  loadCall() {
    var Tawk_API=Tawk_API||{}, Tawk_LoadStart=new Date();
    (function(){
        var s1=document.createElement("script"),s0=document.getElementsByTagName("script")[0];
        s1.async=true;
        // s1.src='https://embed.tawk.to/5d36c2736d80831228398d09/default';   // test
        s1.src='https://embed.tawk.to/5614ffa82ee46dc72a5d2929/default';      // real
        s1.charset='UTF-8';
        s1.setAttribute('crossorigin','*');
        s0.parentNode.insertBefore(s1,s0);
    })();
  }

  constructor(props) {
    super(props);
    this.loadCall();
  }

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
        {/* <ChatBox/> */}
      </div>
    );
  }
}

export default Athena;
