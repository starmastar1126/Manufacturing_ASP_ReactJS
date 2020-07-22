import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";
import FormControl from "@material-ui/core/FormControl";
import InputLabel from "@material-ui/core/InputLabel";
import Select from "@material-ui/core/Select";
import MenuItem from "@material-ui/core/MenuItem";

// @material-ui/icons

// core components
import Button from "components/CustomButtons/Button.jsx";
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";

// athena components
import AthenaCarousel from "components/Athena/AthenaCarousel.jsx";
import AthenaSelect from "components/Athena/AthenaSelect.jsx";
import AthenaInput from "components/Athena/AthenaInput.jsx";

// assets jss
import homePageStyle from "assets/jss/material-dashboard-pro-react/athena/homePageStyle.jsx";

// assets images
import productImage from "assets/img/athena/homepage/product-1.jpg";
import youtubeImage from "assets/img/athena/homepage/youtube.webp";

const cityList = [
  {value: '1', text: 'Alberton'},
  {value: '2', text: 'Alexander Bay'},
  {value: '3', text: 'Allen Grove'},
  {value: '4', text: 'Barberton'},
  {value: '5', text: 'Battlefields'},
  {value: '6', text: 'Bojanala Rustenburg'},
  {value: '7', text: 'Boksburg'},
  {value: '8', text: 'Cape Town'},
  {value: '9', text: 'Centurion'},
]

const provinceList = [
  {value: '1', text: 'Eastern Cape'},
  {value: '2', text: 'Free State'},
  {value: '3', text: 'Gauteng'},
  {value: '4', text: 'KwaZulu Natal'},
  {value: '5', text: 'Limpopo'},
  {value: '6', text: 'Mpumalanga'},
  {value: '7', text: 'North West'},
  {value: '8', text: 'Northern Cape'},
  {value: '9', text: 'Western Cape'},
]

const suburbList = [
  {value: '1', text: 'Alberton'},
  {value: '2', text: 'Alexander Bay'},
  {value: '3', text: 'Allen Grove'},
  {value: '4', text: 'Barberton'},
  {value: '5', text: 'Battlefields'},
  {value: '6', text: 'Bojanala Rustenburg'},
  {value: '7', text: 'Boksburg'},
  {value: '8', text: 'Cape Town'},
  {value: '9', text: 'Centurion'},
]

const manufacturingList = [
  {value: '1', text: 'Aerospace and Defense'},
  {value: '2', text: 'Automotive Manufacturers'},
  {value: '3', text: 'Chemicals'},
  {value: '4', text: 'ICT and Electronics'},
  {value: '5', text: 'Machinery'},
  {value: '6', text: 'Metals'},
  {value: '7', text: 'Pharmaceutical'},
  {value: '8', text: 'Tooling'},
]

class HomePage extends React.Component {
  
  constructor(props) {
    super(props);
    this.state = {
      company: "",
      province: "",
      city: "",
      suburb: "",
      manufacturing: "",
    };
  }

  handleSimple = event => {
    this.setState({ [event.target.name.name]: event.target.value });
  };
  
  render() {
    const { classes } = this.props;
    return (
      <div className={classes.Acontainer}>
        <GridContainer justify="center">
          <GridItem xs={12} sm={12} md={12}>
            <AthenaCarousel />
          </GridItem>
        </GridContainer>
        <div className={classes.Acontainer}>
        <div className={classes.container}>
          <div style={{padding: '5%', backgroundColor: '#fff'}}>
            <GridContainer justify="center">
              <GridItem xs={12} sm={12} md={4}>
                <img src={productImage} alt="..." style={{width: '100%'}} />
              </GridItem>
              <GridItem xs={12} sm={12} md={8} md container>
                <GridItem xs={12} sm={12} md={12}>
                  <h3 style={{fontWeight: 'bold', padding: 0, margin: 0, color: '#222'}}>HOW IT WORKS?</h3>
                  <h5 className={classes.description} style={{color: '#222'}}>
                    LEADS GENERATOR AND BUSINESS MATCH MAKING ANALYTICAL SYSTEM
                  </h5>
                </GridItem>
                <GridItem xs={12} sm={12} md={6} md container>
                  <GridItem xs={12} sm={12} md={2}>
                    <Button justIcon round color="reddit">
                      <i
                        className={
                          classes.socialButtonsIcons + " fab fa-reddit"
                        }
                      />
                    </Button>
                  </GridItem>
                  <GridItem xs={12} sm={12} md={10}>
                    <h5 className={classes.description} style={{color: '#222', padding: 0, margin: 0}}>
                      STEP-1
                    </h5>
                    <h5 style={{fontWeight: 'bold', padding: 0, margin: 0, color: '#222'}}>SERVICE OR PRODUCT</h5>
                    <h8 className={classes.description} style={{color: '#222'}}>
                      Capture what you PRODUCE with VOLUMES and TIMELINES
                    </h8>
                  </GridItem>
                </GridItem>
                <GridItem xs={12} sm={12} md={6} md container>
                  <GridItem xs={12} sm={12} md={2}>
                    <Button justIcon round color="reddit">
                      <i
                        className={
                          classes.socialButtonsIcons + " fab fa-reddit"
                        }
                      />
                    </Button>
                  </GridItem>
                  <GridItem xs={12} sm={12} md={10}>
                    <h5 className={classes.description} style={{color: '#222', padding: 0, margin: 0}}>
                      STEP-1
                    </h5>
                    <h5 style={{fontWeight: 'bold', padding: 0, margin: 0, color: '#222'}}>SERVICE OR PRODUCT</h5>
                    <h8 className={classes.description} style={{color: '#222'}}>
                      Capture what you PRODUCE with VOLUMES and TIMELINES
                    </h8>
                  </GridItem>
                </GridItem>
              </GridItem>
            </GridContainer>
          </div>
        </div>
        </div>
        <div className={classes.Bcontainer}>
        <div className={classes.container}>
          <div style={{padding: '2.5%', backgroundColor: '#444'}}>
            <GridContainer justify="center">
              <GridItem xs={12} sm={12} md={6}>
                <div style={{padding: '2.5%'}}>
                  <h4 style={{fontWeight: 'bold', textAlign: 'center', color: '#fff'}}>This is how it works, View the video</h4>
                  <div style={{backgroundSize: 'cover', margin: 'auto', width: '360px', height: '270px', backgroundImage: 'url(' + youtubeImage + ')'}}>
                  </div>
                </div>
              </GridItem>
              <GridItem xs={12} sm={12} md={6}>
                <div style={{backgroundColor: '#222', padding: '2.5%', width: '100%', height: '100%'}}>
                  <h5 style={{fontWeight: 'bold', textAlign: 'center', color: '#fff'}}>Let us assist in What you looking for</h5>
                  <div style={{display: 'table', margin: 'auto', height: "80%", width: '80%'}}>
                    <div style={{verticalAlign: 'middle', display: 'table-cell'}}>
                      <form>
                        <AthenaInput
                          labelText="Item Required *"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            type: "item",
                          }}
                        />
                        <AthenaInput
                          labelText="Enter Description *"
                          formControlProps={{
                            fullWidth: true
                          }}
                          inputProps={{
                            type: "description",
                          }}
                        />
                        <div>
                          <small>*</small> Required fields
                        </div>
                        <div>
                          <Button color="pinterest">
                            NEXT
                          </Button>
                        </div>
                      </form>
                    </div>
                  </div>
                </div>
              </GridItem>
            </GridContainer>
          </div>
          </div>
          <div className={classes.Ccontainer}>
            <div className={classes.container}>
              <div style={{padding: '2.5%', backgroundColor: '#e3e3e3'}}>
                <GridContainer justify="center">
                  <GridItem xs={12} sm={12} md={12}>
                    <h3 style={{fontWeight: 'bold', color: '#222', textAlign: 'center', textTransform: 'none'}}>
                      Enter the world of Opportunity!
                    </h3>
                  </GridItem>
                  <GridItem xs={12} sm={12} md={12} md container>
                    <GridItem xs={12} sm={12} md={6}>
                      <div style={{height: '95%', backgroundColor: '#bd1627', padding: '2.5%', ':hover': {backgroundColor: '#000'}}}>
                        <div style={{height: 'auto', margin: 'auto'}}>
                          <h4 style={{fontWeight: 'bold', color: '#fff', textAlign: 'center', textTransform: 'none'}}>Business Owners</h4>
                          <h6 className={classes.description} style={{color: '#fff', textAlign: 'center', textTransform: 'none'}}>
                            Take your business to the next level
                          </h6>
                        </div>
                      </div>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={6}>
                      <div style={{height: '95%', backgroundColor: '#bd1627', padding: '2.5%', ':hover': {backgroundColor: '#000'}}}>
                        <div style={{height: 'auto', margin: 'auto'}}>
                          <h4 style={{fontWeight: 'bold', color: '#fff', textAlign: 'center', textTransform: 'none'}}>Require a Quote for a Product or Service</h4>
                          <h6 className={classes.description} style={{color: '#fff', textAlign: 'center', textTransform: 'none'}}>
                            Register here and submit your request online
                          </h6>
                        </div>
                      </div>
                    </GridItem>
                  </GridItem>
                </GridContainer>
              </div>
            </div>
          </div>
          <div className={classes.Dcontainer}>
          <div className={classes.container}>
          <div style={{backgroundColor: '#333'}}>
            <GridContainer justify="center">
              <GridItem xs={12} sm={12} md={12}>
                <div style={{backgroundColor: '#222', padding: '5%', width: '100%', height: '100%'}}>
                  <h5 style={{textAlign: 'center', color: '#fff'}}>Manufacturing Companies</h5>
                  <h6 style={{textAlign: 'center', color: '#fff', textTransform: 'uppercase'}}>Listed companies with full contact details</h6>
                  <div style={{display: 'table', margin: 'auto', height: "80%", width: '90%'}}>
                    <div style={{textAlign: 'center', verticalAlign: 'middle', display: 'table-cell'}}>
                      <GridContainer>
                        <GridItem xs={12} sm={12} md={4}>
                          <AthenaInput
                            formControlProps={{
                              fullWidth: true
                            }}
                            inputProps={{
                              placeholder: 'Search by Company Name',
                              type: "description"
                            }}
                          />
                        </GridItem>
                        <GridItem xs={12} sm={12} md={4}>
                          <AthenaSelect
                            label='Select Province'
                            placeholder='Select Province'
                            menuItems={provinceList}
                            value={this.state.province}
                            onChange={this.handleSimple}
                            name='province'
                            id='select-province'
                          />
                        </GridItem>
                        <GridItem xs={12} sm={12} md={4}>
                          <AthenaSelect
                            label='All City'
                            placeholder='All City'
                            menuItems={cityList}
                            value={this.state.city}
                            onChange={this.handleSimple}
                            name='city'
                            id='select-city'
                          />
                        </GridItem>
                        <GridItem xs={12} sm={12} md={6}>
                          <AthenaSelect
                            label='All Suburb'
                            placeholder='All Suburb'
                            menuItems={suburbList}
                            value={this.state.suburb}
                            onChange={this.handleSimple}
                            name='suburb'
                            id='select-suburb'
                          />
                        </GridItem>
                        <GridItem xs={12} sm={12} md={6}>
                          <AthenaSelect
                            label='All Manufacturing'
                            placeholder='All Manufacturing'
                            menuItems={manufacturingList}
                            value={this.state.manufacturing}
                            onChange={this.handleSimple}
                            name='manufacturing'
                            id='select-manufacturing'
                          />
                        </GridItem>
                        <GridItem xs={12} sm={12} md={12}>
                        <div style={{margin: 20}}>
                          <Button color="pinterest">
                            Search
                          </Button>
                        </div>
                        </GridItem>
                      </GridContainer>
                    </div>
                  </div>
                </div>
              </GridItem>
            </GridContainer>
          </div>
          </div></div>
        </div>
      </div>
    );
  }
}

HomePage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(homePageStyle)(HomePage);
