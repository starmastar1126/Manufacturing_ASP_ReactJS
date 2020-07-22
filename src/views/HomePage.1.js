import React from 'react';
import Slider from 'react-animated-slider';
import horizontalCss from 'react-animated-slider/build/horizontal.css';

import HowItsWorks from '../components/HowItsWorks'
import Select from '../components/Select'

import image01 from '../assets/img/create/img05.jpg'

import icon01 from '../assets/img/icon1.jpg'
import icon02 from '../assets/img/icon2.jpg'
import icon03 from '../assets/img/icon3.jpg'
import icon04 from '../assets/img/icon4.jpg'

import slider1 from '../assets/img/slider_Machinery.jpeg'
import slider2 from '../assets/img/slider_camical.jpeg'
import slider3 from '../assets/img/slider_Electronics.jpeg'
import slider4 from '../assets/img/slider_metal.jpeg'
import slider5 from '../assets/img/slider_Pharmaceutical.jpeg'
import slider6 from '../assets/img/slider_Textiles.jpeg'
import slider7 from '../assets/img/slider_tools.jpeg'
import slider8 from '../assets/img/slider_waste.jpeg'
import slider9 from '../assets/img/slider_Textiles.jpeg'

import requestPng from '../assets/img/request_tyres_side.png'
import RequestItem from '../components/RequestItem.js'

const howitsworksData = [
  {
    index: "1", 
    image: icon01,
    title: "SERVICE or PRODUCT",
    description: "Capture what you PRODUCE with VOLUMES & TIMELINES"
  },
  {
    index: "2", 
    image: icon02,
    title: "CONSUME",
    description: "Capture what you CONSUME with VOLUMES & TIMELINES"
  },
  {
    index: "3", 
    image: icon03,
    title: "LEADS GENERATION",
    description: "We will MATCH YOU to Consumers and Suppliers by Location"
  },
  {
    index: "4", 
    image: icon04,
    title: "SALE",
    description: "Increase your SALES targets !!"
  }
]

const sliderData = [
  {
    index: "1", 
    image: slider1,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "2", 
    image: slider2,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "3", 
    image: slider3,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "4", 
    image: slider4,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "5", 
    image: slider5,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "6", 
    image: slider6,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "7", 
    image: slider7,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
  {
    index: "8", 
    image: slider8,
    title: "Search for any Business",
    description: "in the Industrial & Manufacturing industry.",
    title3: "Search by Company Name, Category or Location",
    button: 'Read More'
  },
]

const selectData = [
  {
    index: "1",
    id: "cboRequestCategory",
    name: "ctl00$cphBody$cboRequestCategory", 
    tabIndex: "153",
    classes: "ddlist",
    options: [
      { value: '0', content: 'Select Category'},
      { value: '1416', content: 'Aerospace  and  Defense'},
      { value: '1441', content: 'Arts  and  Grafts'},
      { value: '1415', content: 'Automotive Manufacturers'},
      { value: '1337', content: 'Chemicals'},
    ]
  },
  {
    index: "2",
    id: "cboRequestProvince",
    name: "ctl00$cphBody$cboRequestProvince", 
    tabIndex: "156",
    classes: "ddlist",
    options: [
      { value: '0', content: 'Select Province'},
      { value: '2', content: 'Eastern Cape'},
      { value: '4', content: 'Free State'},
      { value: '1', content: 'Gauteng'},
      { value: '3', content: 'KwaZulu Natal'},
    ]
  },
  {
    index: "3",
    id: "cboRequestCity",
    name: "ctl00$cphBody$cboRequestCity", 
    tabIndex: "157",
    classes: "ddlist",
    options: [
      { value: '0', content: 'Select City'},
      { value: '1280', content: 'Alberton'},
      { value: '1382', content: 'Alexander Bay'},
      { value: '1395', content: 'Allen Grove'},
      { value: '1239', content: 'Amanzimtoti'},
    ]
  },
  {
    index: "4",
    id: "cboRequestSuburb",
    name: "ctl00$cphBody$cboRequestSuburb", 
    tabIndex: "158",
    classes: "ddlist",
    options: [
      { value: '0', content: 'Select Suburb'},
      { value: '3912', content: '11 Urtel Rd'},
      { value: '3885', content: '138 Main Reef Rd'},
      { value: '3751', content: '22'},
      { value: '3911', content: '236 Zambezi Drive'},
    ]
  },
  {
    index: "5",
    id: "province",
    name: "", 
    tabIndex: "",
    classes: "",
    placeHolder: "All Province",
    options: [
      { value: '0', content: 'Select Province'},
      { value: '2', content: 'Eastern Cape'},
      { value: '4', content: 'Free State'},
      { value: '1', content: 'Gauteng'},
      { value: '3', content: 'KwaZulu Natal'},
    ]
  },
  {
    index: "6",
    id: "city",
    name: "", 
    tabIndex: "",
    classes: "",
    placeHolder: "All City",
    options: [
      { value: '0', content: 'Select City'},
      { value: '1', content: 'Eastern Cape'},
      { value: '2', content: 'Free State'},
      { value: '3', content: 'Gauteng'},
      { value: '4', content: 'KwaZulu Natal'},
    ]
  },
  {
    index: "7",
    id: "suburb",
    name: "", 
    tabIndex: "",
    classes: "",
    placeHolder: "All Suburb",
    options: [
      { value: '0', content: 'Select Suburb'},
      { value: '1', content: 'Eastern Cape'},
      { value: '2', content: 'Free State'},
      { value: '3', content: 'Gauteng'},
      { value: '4', content: 'KwaZulu Natal'},
    ]
  },
  {
    index: "7",
    id: "stock",
    name: "", 
    tabIndex: "",
    classes: "",
    placeHolder: "All Stock",
    options: [
      { value: '0', content: 'Select Stock'},
      { value: '1', content: 'Eastern Cape'},
      { value: '2', content: 'Free State'},
      { value: '3', content: 'Gauteng'},
      { value: '4', content: 'KwaZulu Natal'},
    ]
  }
]
   
class HomePage extends React.Component {
  constructor(props) {
      super(props);
      this.state = {
        showHideRequestItemState: false
      };
      this.showHideRequestItemDialog = this.showHideRequestItemDialog.bind(this);
  }

  showHideRequestItemDialog(){
    const { showHideRequestItemState } = this.state;
    if(showHideRequestItemState === false){
      this.setState({showHideRequestItemState: true});
    } else {
      this.setState({showHideRequestItemState: false})
    }
  }
  cmdRDNext() {      
    if(document.getElementById('txtTitle').value === ''){
      document.getElementById('rfvtxtTitle').className = 'show';
    }
    else if(document.getElementById('txtTitle').value !== ''){
      document.getElementById('rfvtxtTitle').className = 'hide';
    }
    if(document.getElementById('txtDescription').value === ''){
      document.getElementById('rfvtxtDescription').className = 'show';
    }
    else if(document.getElementById('txtDescription').value !== ''){
      document.getElementById('rfvtxtDescription').className = 'hide';
    }
    if(document.getElementById('txtTitle').value !== '' && document.getElementById('txtDescription').value !== ''){
      document.getElementById('rfvtxtTitle').className = 'hide';
      document.getElementById('rfvtxtDescription').className = 'hide';
      document.getElementById('dvRequestDetails').className = 'hide';
      document.getElementById('dvCategoryDetails').className = 'show';
    }
  }
  cmdCAPrev(){
    document.getElementById('dvCategoryDetails').className = 'hide';
    document.getElementById('dvRequestDetails').className = 'show';
  }
  cmdCANext(){
    if(document.getElementById('cboRequestCategory').value === '0'){
      document.getElementById('rfvcboRequestCategory').className = 'show'
    }
    else{
      document.getElementById('dvCategoryDetails').className = 'hide';
      document.getElementById('rfvcboRequestCategory').className = 'hide'
      document.getElementById('dvAreaDetails').className = 'show'
    }
  }
  cmdADPrev(){
    document.getElementById('dvAreaDetails').className = 'hide';
    document.getElementById('dvCategoryDetails').className = 'show';
  }
  cmdADNext(){
    if(document.getElementById('cboRequestProvince').value === '0'){
      document.getElementById('rfvcboRequestProvince').className = 'show'
    }
    else{
      document.getElementById('rfvcboRequestProvince').className = 'hide'
    }
    if(document.getElementById('cboRequestCity').value === '0'){
      document.getElementById('rfvcboRequestCity').className = 'show'
    }
    else{
      document.getElementById('rfvcboRequestCity').className = 'hide'
    }
    if(document.getElementById('cboRequestSuburb').value === '0'){
      document.getElementById('rfvcboRequestSuburb').className = 'show'
    }
    else{
      document.getElementById('rfvcboRequestSuburb').className = 'hide'
    }
    if(document.getElementById('cboRequestProvince').value !== '0' && document.getElementById('cboRequestCity').value !== '0' && document.getElementById('cboRequestSuburb').value !== '0'){
      document.getElementById('rfvcboRequestProvince').className = 'hide'
      document.getElementById('rfvcboRequestCity').className = 'hide'
      document.getElementById('rfvcboRequestSuburb').className = 'hide'
      document.getElementById('dvCategoryDetails').className = 'hide';
      document.getElementById('dvAreaDetails').className = 'hide';
      document.getElementById('dvImageDetails').className = 'show';
      
    }
  }
  cmdUIPrev(){
    document.getElementById('dvImageDetails').className = 'hide';
    document.getElementById('dvAreaDetails').className = 'show';
  }
  cmdUINext(){
    document.getElementById('dvImageDetails').className = 'hide';
    document.getElementById('dvRegisterDetails').className = 'show';
  }
  cmdRegPrev(){
    document.getElementById('dvRegisterDetails').className = 'hide';
    document.getElementById('dvImageDetails').className = 'show';
  }
  cmdRegNext(){
    var reg = /^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/
    if(document.getElementById("txtREmail").value.length == 0) {
      document.getElementById("rfvtxtREmail").className = "show";
    } else{
      document.getElementById("rfvtxtREmail").className = "hide";
    }
    if(document.getElementById("txtREmail").value.length > 0 && !reg.test(document.getElementById("txtREmail").value)) {
      document.getElementById("cvtxtREmail").className = "show";
    } else{
      document.getElementById("cvtxtREmail").className = "hide";
    }
    if(document.getElementById("txtRMobileNumber").value.length == 0 ){
      document.getElementById("rfvtxtRMobileNumber").className ="show"
    } else {
      document.getElementById("rfvtxtRMobileNumber").className = "hide"
    }
    if(isNaN(Number(document.getElementById("txtRMobileNumber").value))){
      document.getElementById("csttxtRMobileNumber").className = "show";
    } else {
      document.getElementById("csttxtRMobileNumber").className = "hide";
    }
    if(document.getElementById("txtREmail").value.length > 0 && reg.test(document.getElementById("txtREmail").value) && document.getElementById("txtRMobileNumber").value.length > 0 && !isNaN(Number(document.getElementById("txtRMobileNumber").value))){
      document.getElementById('dvRegisterDetails').className = 'hide';
      document.getElementById('dvLoginDetails').className = 'show';
    }
  }
  render() {
    return (
      <div>
        <Slider class={horizontalCss} autoplay={1}>            
          {sliderData.map((sliderItem, sliderKey) => {
            return (
              <div
                key={sliderKey}
                style={{ background: `url('${sliderItem.image}') no-repeat center center`, width: '100%' }}
              >
                <div style={{paddingTop: '120px', textAlign: 'center'}}>
                  <p style={{transform: 'skew(20deg)', margin: 'auto', width: '40%', fontSize: '40px', fontWeight: '900', color: '#fff', backgroundColor: '#f00'}}>{sliderItem.title}</p>
                  <p style={{transform: 'skew(-20deg)', margin: 'auto', width: '50%', marginTop: '20px', fontSize: '30px', fontWeight: '900', color: '#000', backgroundColor: '#fff'}}>{sliderItem.description}</p>
                  <p style={{marginTop: '10px', color: '#fff'}}>{sliderItem.title3}</p>
                </div>
              </div>
              );}                      
            )}       
        </Slider>
        <section class="howitsworks">
          <div class="container">
            <div class="row">
              <div class="col-md-4 text-center">
                <img src={image01} alt="" />
              </div>
              <div class="col-md-8 padding_big">
                <h1>How it works?</h1>
                <h2>LEADS GENERATOR AND BUSINESS MATCH MAKING ANALYTICAL SYSTEM</h2>                
                <div class="row">  
                  {howitsworksData.map((howitsworksItem, howitsworksKey) => {
                    return (
                      <HowItsWorks
                        index = {howitsworksItem.index}
                        image = {howitsworksItem.image}
                        title = {howitsworksItem.title}
                        description = {howitsworksItem.description}
                      />
                    );}                      
                  )}        
                </div>                
              </div>
            </div>
          </div>
        </section>

        <section class="section_bg">
          <div class="container">
            <div class="row">
              <div class="col-md-6 text-center">
                <h1>Business Match Making & Leads Generation System</h1><br/>
                {/* <p>Manufacturing, Industrial, Metal <br/> Chemical, Electronic, Textiles, Mining etc...</p> */}
                {/* <img src="assets/img/video.png" alt=""/> */}
                <iframe width="560" height="315" src="https://www.youtube.com/embed/-ItnEvQLJho" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen=""></iframe>
              </div>
              <div class="col-md-6 text-center">
                <div class="bg_form clearfix">
                  <h1>Request any industrial item here, for FREE!!</h1>
                  <div id="dvRequestDetails" class="show">
                    <input name="ctl00$cphBody$txtTitle" type="text" id="txtTitle" tabindex="150" placeholder="Item Required *" />
                    <span id="rfvtxtTitle" class="hide">
                      <span class="help-block has-error">Please Enter What You Require.</span>
                    </span>
                    <input name="ctl00$cphBody$txtDescription" type="text" id="txtDescription" tabindex="151" placeholder="Enter Description *" />
                    <span id="rfvtxtDescription" class="hide">
                      <span class="help-block has-error">Please Enter Description.</span>
                    </span>
                    <input type="button" id="cmdRDNext" class="request" value="Next" tabindex="152" onClick={this.cmdRDNext}/>
                  </div>

                  <div id="dvCategoryDetails" class="hide">
                    <h4 class="tag">Category Information</h4>
                    <hr class="sec-divider"/>
                    <div class="form-group">
                      <label class="control-label compulsory">Category*</label>
                      {selectData.map((selectItem, selectKey) => {
                        if(selectItem.tabIndex === '153'){
                          return (
                            <Select 
                              id={selectItem.id}
                              name={selectItem.name}
                              classes={selectItem.classes}
                              tabIndex={selectItem.tabIndex}
                              options={selectItem.options}
                              />     
                          )}
                        ;}                      
                      )}      
                      <span id="rfvcboRequestCategory" class="hide">
                        <span class="help-block has-error">Please Select Category.</span>
                      </span>
                    </div>
                    <div class="form-group clearfix">
                      <div class="pull-right">
                        <input type="button" id="cmdCAPrev" class="request" value="Previous" tabindex="154" onClick={this.cmdCAPrev}/>
                        <input type="button" id="cmdCANext" class="request marginleft10" value="Next" tabindex="155" onClick={this.cmdCANext}/>
                      </div>
                    </div>
                  </div>

                  <div id="dvAreaDetails" class="hide">
                    <h4 class="tag">Area Information</h4>
                    <hr class="sec-divider"/>
                    <div class="form-group">
                      <label class="control-label compulsory">Province</label>
                      {selectData.map((selectItem, selectKey) => {
                        if(selectItem.tabIndex === '156'){
                          return (
                            <Select 
                              id={selectItem.id}
                              name={selectItem.name}
                              classes={selectItem.classes}
                              tabIndex={selectItem.tabIndex}
                              options={selectItem.options}
                              />     
                          )}
                        ;}                      
                      )}    
                      <span id="rfvcboRequestProvince" class="hide">
                        <span class="help-block has-error">Please Select Province.</span>
                      </span>
                    </div>
                    <div class="form-group">
                      <label class="control-label compulsory">City</label>
                      <div id="dvcboRequestCity">
                        {selectData.map((selectItem, selectKey) => {
                          if(selectItem.tabIndex === '157'){
                            return (
                              <Select 
                                id={selectItem.id}
                                name={selectItem.name}
                                classes={selectItem.classes}
                                tabIndex={selectItem.tabIndex}
                                options={selectItem.options}
                                />     
                            )}
                          ;}                      
                        )}    
                      </div>
                      <span id="rfvcboRequestCity" class="hide">
                        <span class="help-block has-error">Please Select City.</span>
                      </span>
                    </div>
                    <div class="form-group">
                      <label class="control-label compulsory">Suburb</label>
                      <div id="dvcboRequestSuburb">
                        {selectData.map((selectItem, selectKey) => {
                          if(selectItem.tabIndex === '158'){
                            return (
                              <Select 
                                id={selectItem.id}
                                name={selectItem.name}
                                classes={selectItem.classes}
                                tabIndex={selectItem.tabIndex}
                                options={selectItem.options}
                                />     
                            )}
                          ;}                      
                        )}    
                      </div>
                      <span id="rfvcboRequestSuburb" class="hide">
                        <span class="help-block has-error">Please Select Suburb.</span>
                      </span>
                    </div>
                    <div class="form-group clearfix">
                      <div class="pull-right">
                        <input type="button" id="cmdADPrev" class="request" value="Previous" tabindex="159" onClick={this.cmdADPrev}/>
                        <input type="button" id="cmdADNext" class="request marginleft10" value="Next" tabindex="160" onClick={this.cmdADNext}/>
                      </div>
                    </div>
                  </div>

                  <div id="dvImageDetails" class="hide">
                    <h4 class="tag">Upload Photo</h4>
                    <hr class="sec-divider"/>
                    <div class="form-group">
                      <iframe id="ifmUploadFile" name="ifmUploadFile" width="100%" marginheight="0" marginwidth="0" title="Upload File" height="130" scrolling="no" frameborder="0" style={{margin: '0px', padding: '0px'}}></iframe>
                    </div>
                    <div id="dvlUploadImages" class="clearfix marginbott10"></div>
                    <div class="clearfix">
                      <div class="pull-right">
                        <input type="button" id="cmdUIPrev" class="request" value="Previous" tabindex="161" onClick={this.cmdUIPrev} />
                        <input type="button" id="cmdUINext" class="request marginleft10" value="Next" tabindex="162" onClick={this.cmdUINext}/>
                      </div>
                    </div>
                  </div>

                  <div id="dvRegisterDetails" class="hide">
                    <h4 class="tag">Register</h4>
                    <hr class="sec-divider"/>
                    <div class="form-group">
                      <input type="hidden" name="ctl00$cphBody$hdnREmailExists" id="hdnREmailExists" value="0"/>
                      <label class="control-label compulsory">Email</label>
                      <input name="ctl00$cphBody$txtREmail" type="text" id="txtREmail" tabindex="163" placeholder="Enter Email"/>
                      <span id="rfvtxtREmail" class="hide">
                        <span class="help-block has-error">Please enter email address.</span>
                      </span>
                      <span id="cvtxtREmail" class="hide">
                        <span class="help-block has-error">Please enter valid email address.</span>
                      </span>
                    </div>
                    <div class="form-group">
                      <input type="hidden" name="ctl00$cphBody$hdnRMobileNumExists" id="hdnRMobileNumExists" value="0"/>
                      <label class="control-label compulsory">Mobile Number</label>
                      <div class="input-group">
                        <span class="input-group-addon">+27 </span>
                        <input name="ctl00$cphBody$txtRMobileNumber" type="text" maxlength="9" id="txtRMobileNumber" tabindex="164" class="numeric form-control" placeholder="Enter Mobile Number"/>
                      </div>
                      <span id="rfvtxtRMobileNumber" class="hide">
                        <span class="help-block has-error">Please enter mobile number</span>
                      </span>
                      <span id="csttxtRMobileNumber" class="hide">
                        <span class="help-block has-error">Please valid mobile number</span>
                      </span>
                    </div>
                    <label class="control-label">Login with </label>
                    <div class="social-buttons clearfix">
                      <a onclick="fb_login(this,1);" tabindex="169" class="btn social-btn facebook">
                        <i class="fa fa-facebook"></i>Facebook
                      </a>
                      <div id="customgprlogin" tabindex="170" class="btn social-btn googleplus customGPlusSignIn" data-gapiattached="true">
                        <i class="fa fa-google-plus"></i>Google+
                      </div>
                      <a id="linkedInBtn" class="btn social-btn linkedin" style={{cursor: 'pointer'}} onclick="jsfn_LinkedInLogin(1)">
                        <i class="fa fa-linkedin"></i>LinkedIn
                      </a>
                    </div>
                    <div class="form-group clearfix">
                      <div class="pull-right">
                        <input type="button" id="cmdRegPrev" class="request" value="Previous" tabindex="165" onClick={this.cmdRegPrev}/>
                        <input type="button" id="cmdRegNext" class="request marginleft10" value="Request" tabindex="166" onClick={this.cmdRegNext}/>
                      </div>
                    </div>
                    <div class="clearfix"></div>
                  </div>

                  <div id="dvLoginDetails" class="hide">
                    <h4 class="tag">Login</h4>
                    <hr class="sec-divider"/>
                    <div class="form-group">
                      <label class="control-label compulsory">User Name</label>
                      <input name="ctl00$cphBody$txtRUserName" type="text" id="txtRUserName" tabindex="167" class="control-label" />
                      <span id="rfvtxtRUserName" class="hide">
                        <span class="help-block has-error">Please enter username.</span>
                      </span>
                    </div>
                    <div class="form-group">
                      <label class="control-label compulsory">Password</label>
                      <input name="ctl00$cphBody$txtRPassword" type="password" id="txtRPassword" tabindex="168" class="control-label" />
                      <span id="rfvtxtRPassword" class="hide">
                        <span class="help-block has-error">Please enter password.</span>
                      </span>
                    </div>
                    <div class="clearfix">
                      <div class="pull-right">
                          <input type="button" id="cmdULPrev" class="request" value="Previous" tabindex="171" />
                          <input type="button" id="cmdULNext" class="request marginleft10" value="Login &amp;Request" tabindex="172" />
                      </div>
                    </div>
                    <div style={{clear: 'both'}}></div>
                  </div>



                </div>
              </div>
            </div>
          </div>
        </section>

        <section class="opportunity">
          <div class="container">
            <div class="innercontainer" style={{margin: '0 auto'}}>
              <h1>Enter the world of Opportunity!</h1>
              <div class="row">
                <div class="col-md-5">
                  <a href="/business-package-selection-page">
                    <div class="reg_col">
                      <h2>Business User </h2>
                      <h3>Take your business to the next level </h3>
                    </div>
                  </a>
                </div>
                <div class="col-md-2"><div class="or">or</div></div>
                <div class="col-md-5">
                  <a href="/individual-registration-page">
                    <div class="reg_col reg_col2">
                      <h2>Seeker</h2>
                      <h3>Find your requirements here with ease</h3>
                    </div>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </section>

        <section class="section_business">
          <div class="container">
            <h1>Search for any Business </h1>
            <p>in the Industrial & Manufacturing industry.</p>
            <p>Search by Company Name, Category or Location</p>
                
            <div class="business_form">
              <form>
                <div class="row">
                  <div class="col-md-4">
                    <input type="text" name="" placeholder="Search by Company name"/>
                  </div>
                  <div class="col-md-4">
                    {selectData.map((selectItem, selectKey) => {
                      if(selectItem.id === 'province'){
                        return (
                          <Select 
                            id={selectItem.id}
                            name={selectItem.name}
                            classes={selectItem.classes}
                            tabIndex={selectItem.tabIndex}
                            options={selectItem.options}
                            />     
                        )}
                      ;}                      
                    )}   
                  </div>
                  <div class="col-md-4">
                    {selectData.map((selectItem, selectKey) => {
                      if(selectItem.id === 'city'){
                        return (
                          <Select 
                            id={selectItem.id}
                            name={selectItem.name}
                            classes={selectItem.classes}
                            tabIndex={selectItem.tabIndex}
                            options={selectItem.options}
                            />     
                        )}
                      ;}                      
                    )}   
                  </div>
                </div>
                <div class="row">
                  <div class="col-md-6">
                    {selectData.map((selectItem, selectKey) => {
                      if(selectItem.id === 'suburb'){
                        return (
                          <Select 
                            id={selectItem.id}
                            name={selectItem.name}
                            classes={selectItem.classes}
                            tabIndex={selectItem.tabIndex}
                            options={selectItem.options}
                            />     
                        )}
                      ;}                      
                    )}   
                  </div>
                  {/* <div class="col-md-6">
                    {selectData.map((selectItem, selectKey) => {
                      if(selectItem.id === 'stock'){
                        return (
                          <Select 
                            id={selectItem.id}
                            name={selectItem.name}
                            classes={selectItem.classes}
                            tabIndex={selectItem.tabIndex}
                            options={selectItem.options}
                            />     
                        )}
                      ;}                      
                    )}   
                  </div> */}
                </div>
                <div class="row text-center">
                  <input class="searchbtn" type="submit" name="" value="search"/>
                </div>  
              </form>
            </div>
          </div>
        </section>
        <a onClick={this.showHideRequestItemDialog} id="menu-toggle"><img src={requestPng} alt=""/></a>
        <RequestItem showHideProps={this.state.showHideRequestItemState} />
      </div>
    );
  }
}

export default HomePage;
