import React from "react";
// nodejs library that concatenates classes
import classNames from "classnames";
// nodejs library to set properties for components
import PropTypes from "prop-types";
// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";
// @material-ui/icons
import { MDBCard, MDBCardBody, MDBCardTitle, MDBCardText, MDBCardHeader, MDBBtn, MDBContainer } from "mdbreact";

// core components
// import athenaPaymentCardStyle from "assets/jss/material-dashboard-pro-react/components/athenaPaymentCardStyle.jsx";

class AthenaPaymentCard extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      currentStep: 0,
      color: this.props.color,
      nextButton: this.props.steps.length > 1 ? true : false,
      previousButton: false,
      finishButton: this.props.steps.length === 1 ? true : false,
      width: width,
      movingTabStyle: {
        transition: "transform 0s"
      },
      allStates: {}
    };
  }

  render() { 
    const {
      classes,
      className,
      paymentTitle,
      paymentPercent,
      paymentCost,
      paymentRealCost,
      paymentElement,
      paymentSelected,
      ...rest
    } = props;
    return (
      <div className={cardClasses} {...rest}>
        <MDBContainer>
          <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(0, 0, 0, 0.1)"}}>
            <div style={{textAlign: "center", fontSize: "20px", fontWeight: "500"}}><MDBCardHeader style={{backgroundColor: "#4C5457"}}>CORPORATE</MDBCardHeader></div>
            <div style={{width: "50px", height: "50px", position: "absolute", left: "75%", top: "20px", backgroundColor: "#d81b60", borderRadius: "50% 50% 50% 50%", padding: "3px 0 0 3px", fontSize: "12px", fontWeight: "500", textAlign: "center"}}><p style={{height: "12px"}}>15%</p><p style={{height: "12px"}}>OFF</p></div>
            <div style={{width: "100%", height: "150px", backgroundColor: "#96A4AB", borderRadius: "0 0 0 35px", padding: "30px 0 30px 0"}}>
              <p style={{textAlign: "center", fontSize: "25px", fontWeight: "800", verticalAlign: "text-bottom", textDecorationLine: "line-through"}}>R450,000.00</p>
              <p style={{textAlign: "center", fontSize: "35px", fontWeight: "1000", verticalAlign: "text-bottom"}}>R 382,500.00</p>
              <p style={{textAlign: "center", fontSize: "15px", fontWeight: "300", verticalAlign: "text-bottom"}}>PER 9 MONTH</p>
            </div>
            <div style={{padding: "30px 0 20px 0"}}>

              <p style={{color: "#6D6D6D"}}>2 HRS TIME DELAY</p>
              <p style={{color: "#6D6D6D"}}>UNLIMITED CATEGORY</p>
              <p style={{color: "#6D6D6D"}}>UNLIMITED USERS</p>
              <p style={{color: "#6D6D6D"}}>300 REQUESTS</p>
              <p style={{color: "#6D6D6D"}}>50 SPECIAL</p>
              <p style={{color: "#6D6D6D"}}>50 E-FLYERS</p>
              <p style={{color: "#6D6D6D"}}>UNLIMITED SALES LEAD</p>
              <p style={{color: "#6D6D6D"}}>100 KEYWORDS</p>
              <p style={{color: "#6D6D6D"}}>CRM</p>
              <p style={{color: "#6D6D6D"}}>PAYFAST INTEGRATION</p>
            </div>
            <div style={{textAlign: "center", padding: "0 0 20px 0"}}>
              <Button color="default" size="sm" round className={classes.marginRight}>
                Select
              </Button>
            </div>
          </MDBCard>
        </MDBContainer>
      </div>
    );
  }
}

AthenaPaymentCard.propTypes = {
  classes: PropTypes.object.isRequired,
  className: PropTypes.string,
  paymentTitle: PropTypes.string,
  paymentPercent: PropTypes.number,
  paymentCost: PropTypes.string,
  paymentRealCost: PropTypes.string,
  paymentElement: PropTypes.arrayOf(
    PropTypes.shape({
      content: PropTypes.string
    })
  ),
  paymentSelected: PropTypes.bool,
};

export default withStyles(athenaPaymentCardStyle)(AthenaPaymentCard);
