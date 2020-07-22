import React from 'react';

import logo from '../assets/img/logo.png'

import RegisterDialog from '../components/RegisterDialog';

class Header extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
          active: window.location.pathname,
          registerVsible : false
        };
        this.registerHandler = this.registerHandler.bind(this);
    }
  
    registerHandler() {
        const {registerVsible} = this.state;

        if(registerVsible === false){
            this.setState({registerVsible : true});
        } else {
            this.setState({registerVsible : false});
        }
    }
  
    render() {
        return (
            <div className="sticky">
            <section className="header">
                <div className="topheader">
                    <div className="container">
                    <div className="row">
                        <div className="col-md-6">
                            <div className="applist">
                            <p style={{marginBottom: 0, paddingBottom: 0}}>EZYFIND Apps for</p>
                            <ul>
                                <li><a href="https://itunes.apple.com/us/app/ezyfind/id980233151?ls=1&mt=8">iPHONE</a></li>
                                <li><a href="https://play.google.com/store/apps/details?id=com.INNOVEzyFind">ANDROID</a></li>
                                <li><a href="http://www.windowsphone.com/en-in/store/app/ezyfind/6d32b44b-cdb4-4404-8f4d-09542a33934f">WINDOWS</a></li>
                            </ul>
                            </div>
                        </div>
                        <div className="col-md-6">
                            <div className="lgin">
                            <p style={{marginBottom: 0, paddingBottom: 0}}>Hi Guest</p>
                            <ul>
                                <li><a onClick={this.registerHandler}>Register</a></li>
                                <li><a href="/login-page">Login</a></li>
                            </ul>
                            </div>
                        </div>
                    </div> 
                    </div>     
                </div>

                <div className="mainnav">
                    <div className="container">
                    <button className="menu-button"></button>
                    <div className="logo"><a href="/home-page"><img src={logo} alt=""/></a></div>
                    <nav className="mobile_primary">
                        <ul id="menu-main-navigation-1" className="menu">
                        <li className={this.state.active === '/home-page' || this.state.active === '/' ? 'current-menu-item' : ''}><a href='/home-page'>HOME</a></li>
                        {/* <li className={this.state.active === '/product-list-page' ? 'current-menu-item' : ''}><a href='/product-list-page'>Products</a></li> */}
                        <li className={this.state.active === '/business-list-page' ? 'current-menu-item' : ''}><a href='/business-list-page'>Manufacturers</a></li>
                        <li className={this.state.active === '/view-magazines-page' ? 'current-menu-item' : ''}><a href='/view-magazines-page'>Digital Catalogues</a></li>
                        <li className={this.state.active === '/special-list-page' ? 'current-menu-item' : ''}><a href='/special-list-page'>Specials</a></li>
                        <li className={this.state.active === '/competition-page' ? 'current-menu-item' : ''}><a href='/competition-page'>Competition</a></li>
                        <li className={this.state.active === '/business-package-selection-page' ? 'current-menu-item' : ''}><a href='/business-package-selection-page'>List Your Business</a></li>
                        <li className={this.state.active === '/contact-us-page' ? 'current-menu-item' : ''}><a href='/contact-us-page'>Contact</a></li>
                        <li className={this.state.active === '/about-us-page' ? 'current-menu-item' : ''}><a href='/about-us-page'>About</a></li>
                        </ul>         
                    </nav>        
                    </div>
                </div>
            </section>
            <RegisterDialog registerHandler = {this.registerHandler} visible = {this.state.registerVsible} />
            </div>
        );
    }
}

export default Header;
