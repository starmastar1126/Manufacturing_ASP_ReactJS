import React from "react";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import Button from "components/CustomButtons/Button.jsx";
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";
import { MDBCard, MDBCardHeader, MDBContainer } from "mdbreact";

const style = {
  infoText: {
    fontWeight: "300",
    margin: "10px 0 30px",
    textAlign: "center"
  },
  inputAdornmentIcon: {
    color: "#555"
  },
  inputAdornment: {
    position: "relative"
  }
};

class ListYourBusinessStep1 extends React.Component {
  render() {
    const { classes, stepId } = this.props;
    return (
      <GridContainer alignItems="center">
        <GridItem  xs={12} sm={3}>
          <MDBContainer>
            <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(255, 255, 255, 0.5)"}}>
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
        </GridItem>
        <GridItem  xs={12} sm={3}>
          <MDBContainer>
            <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(255, 255, 255, 0.5)"}}>
              <div style={{textAlign: "center", fontSize: "20px", fontWeight: "500"}}><MDBCardHeader style={{backgroundColor: "#4C5457"}}>FRANCHISEE</MDBCardHeader></div>
              <div style={{width: "50px", height: "50px", position: "absolute", left: "75%", top: "20px", backgroundColor: "#d81b60", borderRadius: "50% 50% 50% 50%", padding: "3px 0 0 3px", fontSize: "12px", fontWeight: "500", textAlign: "center"}}><p style={{height: "12px"}}>15%</p><p style={{height: "12px"}}>OFF</p></div>
              <div style={{width: "100%", height: "150px", backgroundColor: "#96A4AB", borderRadius: "0 0 0 35px", padding: "30px 0 30px 0"}}>
                <p style={{textAlign: "center", fontSize: "25px", fontWeight: "800", verticalAlign: "text-bottom", textDecorationLine: "line-through"}}>R90,000.00</p>
                <p style={{textAlign: "center", fontSize: "35px", fontWeight: "1000", verticalAlign: "text-bottom"}}>R 76,500.00</p>
                <p style={{textAlign: "center", fontSize: "15px", fontWeight: "300", verticalAlign: "text-bottom"}}>PER 9 MONTH</p>
              </div>
              <div style={{padding: "30px 0 20px 0"}}>
                <p style={{color: "#6D6D6D"}}>3 HRS TIME DELAY</p>
                <p style={{color: "#6D6D6D"}}>5 CATEGORY</p>
                <p style={{color: "#6D6D6D"}}>5 USERS</p>
                <p style={{color: "#6D6D6D"}}>200 REQUESTS</p>
                <p style={{color: "#6D6D6D"}}>25 SPECIAL</p>
                <p style={{color: "#6D6D6D"}}>25 E-FLYERS</p>
                <p style={{color: "#6D6D6D"}}>50 SALES LEAD</p>
                <p style={{color: "#6D6D6D"}}>50 KEYWORDS</p>
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
        </GridItem>
        <GridItem  xs={12} sm={3}>
          <MDBContainer>
            <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(255, 255, 255, 0.5)"}}>
              <div style={{textAlign: "center", fontSize: "20px", fontWeight: "500"}}><MDBCardHeader style={{backgroundColor: "#691212"}}>SME</MDBCardHeader></div>
              <div style={{width: "50px", height: "50px", position: "absolute", left: "75%", top: "20px", backgroundColor: "#96A4AB", borderRadius: "50% 50% 50% 50%", padding: "3px 0 0 3px", fontSize: "12px", fontWeight: "500", textAlign: "center"}}><p style={{height: "12px"}}>15%</p><p style={{height: "12px"}}>OFF</p></div>
              <div style={{width: "100%", height: "150px", backgroundColor: "#d81b60", borderRadius: "0 0 0 35px", padding: "30px 0 30px 0"}}>
                <p style={{textAlign: "center", fontSize: "25px", fontWeight: "800", verticalAlign: "text-bottom", textDecorationLine: "line-through"}}>R3,141.00</p>
                <p style={{textAlign: "center", fontSize: "35px", fontWeight: "1000", verticalAlign: "text-bottom"}}>R 2,669.85</p>
                <p style={{textAlign: "center", fontSize: "15px", fontWeight: "300", verticalAlign: "text-bottom"}}>PER 9 MONTH</p>
              </div>
              <div style={{padding: "30px 0 20px 0"}}>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>4 HRS TIME DELAY</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>3 CATEGORY</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>3 USERS</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>100 REQUESTS</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>10 SPECIAL</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>10 E-FLYERS</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>10 SALES LEAD</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>10 KEYWORDS</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>CRM</p>
                <p style={{fontSize: "15px", padding: "5px 0 5px 0", color: "#6D6D6D"}}>PAYFAST INTEGRATION</p>
              </div>
              <div style={{textAlign: "center", padding: "0 0 20px 0"}}>
                <Button color="rose" size="sm" round className={classes.marginRight}>
                  Select
                </Button>
              </div>
            </MDBCard>
          </MDBContainer>
        </GridItem>
        <GridItem  xs={12} sm={3}>
          <MDBContainer>
            <MDBCard text="white" className="text-center" style={{marginTop: "1rem", backgroundColor: "rgba(255, 255, 255, 0.5)"}}>
              <div style={{textAlign: "center", fontSize: "20px", fontWeight: "500"}}><MDBCardHeader style={{backgroundColor: "#4C5457"}}>FREE</MDBCardHeader></div>
              <div style={{width: "100%", height: "150px", backgroundColor: "#96A4AB", borderRadius: "0 0 0 35px", padding: "30px 0 30px 0"}}>
                <p style={{textAlign: "center", fontSize: "25px", fontWeight: "800", verticalAlign: "text-bottom", textDecorationLine: "line-through"}}>-</p>
                <p style={{textAlign: "center", fontSize: "35px", fontWeight: "1000", verticalAlign: "text-bottom"}}>R 0.00</p>
                <p style={{textAlign: "center", fontSize: "15px", fontWeight: "300", verticalAlign: "text-bottom"}}>PER 9 MONTH</p>
              </div>
              <div style={{padding: "30px 0 20px 0"}}>
                <p style={{color: "#6D6D6D"}}>5 HRS TIME DELAY</p>
                <p style={{color: "#6D6D6D"}}>3 CATEGORY</p>
                <p style={{color: "#6D6D6D"}}>1 USERS</p>
                <p style={{color: "#6D6D6D"}}>NO REQUESTS</p>
                <p style={{color: "#6D6D6D"}}>NO SPECIAL</p>
                <p style={{color: "#6D6D6D"}}>NO E-FLYERS</p>
                <p style={{color: "#6D6D6D"}}>NO SALES LEAD</p>
                <p style={{color: "#6D6D6D"}}>NO KEYWORDS</p>
                <p style={{color: "#6D6D6D"}}>CRM</p>
                <p style={{color: "#6D6D6D"}}>NO PAYFAST INTEGRATION</p>
              </div>
              <div style={{textAlign: "center", padding: "0 0 20px 0"}}>
                <Button color="default" size="sm" round className={classes.marginRight}>
                  Select
                </Button>
              </div>
            </MDBCard>
          </MDBContainer>
        </GridItem>
      </GridContainer>
    );
  }
}

export default withStyles(style)(ListYourBusinessStep1);
