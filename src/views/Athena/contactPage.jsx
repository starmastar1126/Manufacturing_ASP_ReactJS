import React from "react";
import PropTypes from "prop-types";
import { MDBInput } from 'mdbreact';

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

import contactPageStyle from "assets/jss/material-dashboard-pro-react/athena/contactPageStyle.jsx";

import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";
import Card from "components/Card/Card.jsx";
import CardHeader from "components/Card/CardHeader.jsx";
import CardBody from "components/Card/CardBody.jsx";
import CardText from "components/Card/CardText.jsx";
import CardIcon from "components/Card/CardIcon.jsx";
import Button from "components/CustomButtons/Button.jsx";
import Favorite from "@material-ui/icons/Favorite";
import TextField from "@material-ui/core/TextField";
import CustomInput from "components/CustomInput/CustomInput.jsx";
import InputAdornment from "@material-ui/core/InputAdornment";
import Close from "@material-ui/icons/Close";
import heddingMarker from "assets/img/athena/contactpage/hedding_marker.png";


class ContactPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      // login form
      loginName: "",
      loginNameState: "",
      loginPhone: "",
      loginPhoneState: "",
      loginEmail: "",
      loginEmailState: "",
      loginSubject: "",
      loginSubjectState: "",
    };
    this.loginClick = this.loginClick.bind(this);
  }
  // function that returns true if value is email, false otherwise
  verifyEmail(value) {
    var emailRex = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    if (emailRex.test(value)) {
      return true;
    }
    return false;
  }
  // function that verifies if a string has a given length or not
  verifyLength(value, length) {
    if (value.length >= length) {
      return true;
    }
    return false;
  }
  // function that verifies if two strings are equal
  compare(string1, string2) {
    if (string1 === string2) {
      return true;
    }
    return false;
  }
  // function that verifies if value contains only numbers
  verifyNumber(value) {
    var numberRex = new RegExp("^[0-9]+$");
    if (numberRex.test(value)) {
      return true;
    }
    return false;
  }
  // verifies if value is a valid URL
  verifyUrl(value) {
    try {
      new URL(value);
      return true;
    } catch (_) {
      return false;
    }
  }
  change(event, stateName, type, stateNameEqualTo, maxValue) {
    switch (type) {
      case "email":
        if (this.verifyEmail(event.target.value)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "password":
        if (this.verifyLength(event.target.value, 1)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "number":
        if (this.verifyNumber(event.target.value)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "length":
        if (this.verifyLength(event.target.value, stateNameEqualTo)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "max-length":
        if (!this.verifyLength(event.target.value, stateNameEqualTo + 1)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "url":
        if (this.verifyUrl(event.target.value)) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "min-value":
        if (
          this.verifyNumber(event.target.value) &&
          event.target.value >= stateNameEqualTo
        ) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "max-value":
        if (
          this.verifyNumber(event.target.value) &&
          event.target.value <= stateNameEqualTo
        ) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      case "range":
        if (
          this.verifyNumber(event.target.value) &&
          event.target.value >= stateNameEqualTo &&
          event.target.value <= maxValue
        ) {
          this.setState({ [stateName + "State"]: "success" });
        } else {
          this.setState({ [stateName + "State"]: "error" });
        }
        break;
      default:
        break;
    }
    switch (type) {
      case "checkbox":
        this.setState({ [stateName]: event.target.checked });
        break;
      default:
        this.setState({ [stateName]: event.target.value });
        break;
    }
  }
  loginClick() {
    if (this.state.loginNameState === "") {
      this.setState({ loginNameState: "error" });
    }
    if (this.state.loginPhoneState === "") {
      this.setState({ loginPhoneState: "error" });
    }
    if (this.state.loginEmailState === "") {
      this.setState({ loginEmailState: "error" });
    }
    if (this.state.loginSubjectState === "") {
      this.setState({ loginSubjectState: "error" });
    }
  }
  render() {
    const { classes } = this.props;
    
    return (
        <div className={classes.container}>
          <div style={{width: "100%", textAlign: "center"}}>
            <CardHeader color="rose" text>
              <CardText color="rose">
                <h4 className={classes.contactTitle} >CONTACT US</h4>
              </CardText>
            </CardHeader>
            <div style={{margin: "auto", marginTop: "20px", width: "420px", height: "26px", backgroundImage: "url(" + heddingMarker + ")"}} />
          </div>
          {/* <GridContainer justify="center">
            <GridItem xs={12} sm={12}>
              <h4 className={classes.contactTitle} >CONTACT US</h4>
              <div style={{margin: "auto", width: "420px", height: "26px", backgroundImage: "url(" + heddingMarker + ")"}} />
            </GridItem>
          </GridContainer> */}
          <div style={{marginTop: "30px"}}>
              <GridContainer justify="center">
                <GridItem xs={12} sm={12} md={6} lg={6}>
                  <Card>
                    <CardHeader color="rose">
                      <h4>STAY IN TOUCH</h4>
                    </CardHeader>
                    <CardBody>
                      <div style={{padding: "30px 30px 30px 30px"}}>
                        <p style={{margin: "0 0 10px", padding: "0 0 5px", fontSize: "20px", color: "#CD2323", lineHeight: "25px", fontWeight: "600", position: "relative"}}>Office Address</p>
                        <Button justIcon round color="info" className={classes.marginRight} size="sm"><i class="material-icons">location_on</i></Button>&nbsp;<a href="#">Delphinium Street Winchester Hills Ext 2 Johannesburg </a>
                        <br/><br/>
                        <p style={{margin: "0 0 10px", padding: "0 0 5px", fontSize: "20px", color: "#CD2323", lineHeight: "25px", fontWeight: "600", position: "relative"}}>Email ID</p>
                        <Button justIcon round color="info" className={classes.marginRight} size="sm"><i class="material-icons">mail</i></Button>&nbsp;<a href="mailto:info@ezyfind.co.za">info@ezyfind.co.za</a>
                        <br/><br/>
                        <p style={{margin: "0 0 10px", padding: "0 0 5px", fontSize: "20px", color: "#CD2323", lineHeight: "25px", fontWeight: "600", position: "relative"}}>Phone Number</p>
                        <Button justIcon round color="info" className={classes.marginRight} size="sm"><i class="material-icons">local_phone</i></Button>&nbsp;<a href="#">+27 11 056 9123</a>
                        <br/><br/>
                        <p style={{margin: "0 0 10px", padding: "0 0 5px", fontSize: "20px", color: "#CD2323", lineHeight: "25px", fontWeight: "600", position: "relative"}}>Online Support</p>
                        <Button justIcon round color="info" className={classes.marginRight} size="sm"><i class="material-icons">priority_high</i></Button>&nbsp;<a href="#chat" onclick="jsfn_OpenChat();">24/7 Support online chat</a>
                      </div>
                    </CardBody>
                  </Card>
                </GridItem>
                <GridItem xs={12} sm={12} md={6} lg={6}>
                  <Card>
                    <CardHeader color="rose">
                      <h4>STAY IN TOUCH</h4>
                    </CardHeader>
                    <CardBody>
                      <form>
                        <CustomInput
                          success={this.state.loginNameState === "success"}
                          error={this.state.loginNameState === "error"}
                          labelText="Full Name *"
                          id="loginname"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "loginName", "length", 5),
                            type: "text"
                          }}
                        />
                        <GridContainer justify="center">
                          <GridItem xs={12} sm={12} md={6} lg={6}>
                            <CustomInput
                              success={this.state.loginPhoneState === "success"}
                              error={this.state.loginPhoneState === "error"}
                              labelText="Phone Number *"
                              id="loginphone"
                              formControlProps={{
                                fullWidth: true
                              }}
                              inputProps={{
                                onChange: event =>
                                  this.change(event, "loginPhone", "number"),
                                type: "number",
                                endAdornment:
                                  this.state.numberState === "error" ? (
                                    <InputAdornment position="end">
                                      <Close className={classes.danger} />
                                    </InputAdornment>
                                  ) : (
                                    undefined
                                  )
                              }}
                            />
                          </GridItem>
                          <GridItem xs={12} sm={12} md={6} lg={6}>
                            <CustomInput
                              success={this.state.loginEmailState === "success"}
                              error={this.state.loginEmailState === "error"}
                              labelText="Email Address *"
                              id="loginemail"
                              formControlProps={{
                                fullWidth: true
                              }}
                              inputProps={{
                                onChange: event =>
                                  this.change(event, "loginEmail", "email"),
                                type: "email"
                              }}
                            />
                          </GridItem>
                        </GridContainer>
                        <CustomInput
                          success={this.state.loginSubjectState === "success"}
                          error={this.state.loginSubjectState === "error"}
                          labelText="Subject *"
                          id="loginsubject"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "loginSubject", "length", 5),
                            type: "text"
                          }}
                        />
                        {/* <MDBInput type="textarea" label="Message *" rows="3" /> */}
                        <div className="form-group">
                          <label htmlFor="exampleFormControlTextarea1">
                          Messages *
                          </label>
                          <textarea
                          className="form-control"
                          id="exampleFormControlTextarea1"
                          rows="4"
                          />
                        </div>
                        <div className={classes.right}>
                          <Button color="rose" onClick={this.loginClick}>
                            SUBMIT
                          </Button>
                        </div>
                      </form>
                    </CardBody>
                  </Card>
                </GridItem>
              </GridContainer>
          </div>
        </div>
    );
  }
}

ContactPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(contactPageStyle)(ContactPage);
