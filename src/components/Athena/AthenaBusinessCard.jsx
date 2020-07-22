import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import Button from "components/CustomButtons/Button.jsx";
import { MDBCard, MDBCardHeader, MDBContainer } from "mdbreact";

import athenaBusinessCardStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaBusinessCardStyle.jsx";

class AthenaBusinessCard extends React.Component {

  render() {
    const { classes, athenaTitle, athenaPercent, athenaPrice1, athenaPrice2, athenaMonth, athenaHrs, athenaCategory, athenaUsers, athenaRequests, athenaSpecial, athenaFlyers, athenaSales, athenaKeyword} = this.props;
    return (
      <MDBContainer>
        <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(255, 255, 255, 0.5)"}}>
          <div style={{textAlign: "center", fontSize: "20px", fontWeight: "500"}}><MDBCardHeader style={{backgroundColor: "#4C5457"}}>{athenaTitle}</MDBCardHeader></div>
          <div style={{width: "50px", height: "50px", position: "absolute", left: "75%", top: "20px", backgroundColor: "#d81b60", borderRadius: "50% 50% 50% 50%", padding: "3px 0 0 3px", fontSize: "12px", fontWeight: "500", textAlign: "center"}}><p style={{height: "12px"}}>{athenaPercent}</p><p style={{height: "12px"}}>OFF</p></div>
          <div style={{width: "100%", height: "150px", backgroundColor: "#96A4AB", borderRadius: "0 0 0 35px", padding: "30px 0 30px 0"}}>
            <p style={{textAlign: "center", fontSize: "25px", fontWeight: "800", verticalAlign: "text-bottom", textDecorationLine: "line-through"}}>{athenaPrice1}</p>
            <p style={{textAlign: "center", fontSize: "35px", fontWeight: "1000", verticalAlign: "text-bottom"}}>{athenaPrice2}</p>
            <p style={{textAlign: "center", fontSize: "15px", fontWeight: "300", verticalAlign: "text-bottom"}}>PER {athenaMonth} MONTH</p>
          </div>
          <div style={{padding: "30px 0 20px 0"}}>
            <p style={{color: "#6D6D6D"}}>{athenaHrs} HRS TIME DELAY</p>
            <p style={{color: "#6D6D6D"}}>{athenaCategory} CATEGORY</p>
            <p style={{color: "#6D6D6D"}}>{athenaUsers} USERS</p>
            <p style={{color: "#6D6D6D"}}>{athenaRequests} REQUESTS</p>
            <p style={{color: "#6D6D6D"}}>{athenaSpecial} SPECIAL</p>
            <p style={{color: "#6D6D6D"}}>{athenaFlyers} E-FLYERS</p>
            <p style={{color: "#6D6D6D"}}>{athenaSales} SALES LEAD</p>
            <p style={{color: "#6D6D6D"}}>{athenaKeyword} KEYWORDS</p>
            <p style={{color: "#6D6D6D"}}>CRM</p>
            <p style={{color: "#6D6D6D"}}>{athenaTitle == 'FREE' ? "NO" : ""} PAYFAST INTEGRATION</p>
          </div>
          <div style={{textAlign: "center", padding: "0 0 20px 0"}}>
            <Button color="default" size="sm" round className={classes.marginRight}>
              Select
            </Button>
          </div>
        </MDBCard>
      </MDBContainer>
    );
  }
}

AthenaBusinessCard.propTypes = {
  classes: PropTypes.object.isRequired,
  athenaTitle: PropTypes.string, 
  athenaPercent: PropTypes.string, 
  athenaPrice1: PropTypes.string, 
  athenaPrice2: PropTypes.string, 
  athenaMonth: PropTypes.string, 
  athenaHrs: PropTypes.string, 
  athenaCategory: PropTypes.string, 
  athenaUsers: PropTypes.string, 
  athenaRequests: PropTypes.string, 
  athenaSpecial: PropTypes.string, 
  athenaFlyers: PropTypes.string, 
  athenaSales: PropTypes.string, 
  athenaKeyword: PropTypes.string
 
};

export default withStyles(athenaBusinessCardStyle)(AthenaBusinessCard);
