import React from "react";
import PropTypes from "prop-types";
import { MDBInput } from 'mdbreact';

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

import registrationPageStyle from "assets/jss/material-dashboard-pro-react/athena/registrationPageStyle.jsx";

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
import FormControlLabel from "@material-ui/core/FormControlLabel";
import Checkbox from "@material-ui/core/Checkbox";
import Check from "@material-ui/icons/Check";
import heddingMarker from "assets/img/athena/contactpage/hedding_marker.png";


class RegistrationPage extends React.Component {
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
                <h4 className={classes.contactTitle} >&nbsp;&nbsp;&nbsp;SIGN UP&nbsp;&nbsp;&nbsp;</h4>
              </CardText>
            </CardHeader>
            <div style={{margin: "auto", marginTop: "20px", width: "420px", height: "26px", backgroundImage: "url(" + heddingMarker + ")"}} />
          </div>
          <div style={{marginTop: "30px"}}>
              <GridContainer justify="center">
                <GridItem xs={12} sm={12} md={8} lg={8}>
                  <Card>
                    <CardHeader style={{backgroundColor: "#333"}}>
                      <GridContainer>
                        <GridItem xs={12} sm={12} md={6} lg={6}>
                          <h4 style={{color: "#fff", fontSize: "18px", fontWeight: "600"}}>SIGN UP</h4>
                        </GridItem>
                        <GridItem xs={12} sm={12} md={6} lg={6}>
                          <div className={classes.right}>
                            <h4 style={{display: "inline", textAlign: "right", color: "#fff", fontSize: "15px", fontWeight: "400"}}>Already have an account?&nbsp;&nbsp;&nbsp;</h4>
                            <Button style={{display: "inline"}} color="rose" onClick={this.loginClick}>
                              Sign In
                            </Button>
                          </div>
                        </GridItem>
                      </GridContainer>
                      <GridContainer>
                        <GridItem xs={12} sm={12} md={6} lg={6}>
                          <h4 style={{color: "#fff", fontSize: "18px", fontWeight: "600"}}>SOCIAL LOGIN</h4>
                          <h4 style={{color: "#fff", fontSize: "15px", fontWeight: "400"}}>Sign in by one-click with your social accounts.</h4>
                        </GridItem>
                        <GridItem xs={12} sm={12} md={6} lg={6}>
                          <div className={classes.right}>
                          <Button justIcon round color="facebook" style={{marginRight: "20px"}}>
                            <i
                              className={
                                classes.socialButtonsIcons + " fab fa-facebook"
                              }
                            />
                          </Button>
                          <Button justIcon round color="google" style={{marginRight: "20px"}}>
                            <i
                              className={
                                classes.socialButtonsIcons + " fab fa-google"
                              }
                            />
                          </Button>
                          <Button justIcon round color="linkedin">
                            <i
                              className={
                                classes.socialButtonsIcons + " fab fa-linkedin"
                              }
                            />
                          </Button>
                          </div>
                        </GridItem>
                      </GridContainer>
                    </CardHeader>
                    <CardBody>
                      <form>
                        <h4>We are happy to see you return</h4>
                        <CustomInput
                          success={this.state.firstNameState === "success"}
                          error={this.state.firstNameState === "error"}
                          labelText="First Name *"
                          id="firstname"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "firstName", "length", 2),
                            type: "text"
                          }}
                        />
                        <CustomInput
                          success={this.state.lastNameState === "success"}
                          error={this.state.lastNameState === "error"}
                          labelText="Last Name *"
                          id="lastname"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "lastName", "length", 2),
                            type: "text"
                          }}
                        />
                        <CustomInput
                          success={this.state.emailState === "success"}
                          error={this.state.emailState === "error"}
                          labelText="Email Address *"
                          id="email"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "email", "email"),
                            type: "email"
                          }}
                        />
                        <CustomInput
                          success={this.state.registerPasswordState === "success"}
                          error={this.state.registerPasswordState === "error"}
                          labelText="Password *"
                          id="registerpassword"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(event, "registerPassword", "password"),
                            type: "password"
                          }}
                        />
                        <CustomInput
                          success={
                            this.state.registerConfirmPasswordState === "success"
                          }
                          error={this.state.registerConfirmPasswordState === "error"}
                          labelText="Confirm Password *"
                          id="registerconfirmpassword"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            onChange: event =>
                              this.change(
                                event,
                                "registerConfirmPassword",
                                "equalTo",
                                "registerPassword"
                              ),
                            type: "password"
                          }}
                        />
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
                        <div
                          className={
                            classes.checkboxAndRadio +
                            " " +
                            classes.checkboxAndRadioHorizontal
                          }
                        >
                          <FormControlLabel
                            control={
                              <Checkbox
                                tabIndex={-1}
                                onClick={() => this.handleToggle(3)}
                                checkedIcon={
                                  <Check className={classes.checkedIcon} />
                                }
                                icon={<Check className={classes.uncheckedIcon} />}
                                classes={{
                                  checked: classes.checked,
                                  root: classes.checkRoot
                                }}
                              />
                            }
                            classes={{
                              label: classes.label
                            }}
                            label="First Checkbox"
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

RegistrationPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(registrationPageStyle)(RegistrationPage);
