import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";
import Button from "components/CustomButtons/Button.jsx";
import Card from "components/Card/Card.jsx";
import CardHeader from "components/Card/CardHeader.jsx";
import CardBody from "components/Card/CardBody.jsx";
import CardIcon from "components/Card/CardIcon.jsx";
import CardFooter from "components/Card/CardFooter.jsx";
import CustomInput from "components/CustomInput/CustomInput.jsx";
import FormControl from "@material-ui/core/FormControl";
import InputLabel from "@material-ui/core/InputLabel";
import Select from "@material-ui/core/Select";
import MenuItem from "@material-ui/core/MenuItem";

import specialsPageStyle from "assets/jss/material-dashboard-pro-react/athena/specialsPageStyle.jsx";

import priceImage1 from "assets/img/mc-1.jpg";
import Pagination from "components/Pagination/Pagination.jsx";
import { MDBBtn } from "mdbreact";

class SpecialsPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      checkedA: true,
      checkedB: false,
      simpleSelect: "",
      simpleSelect1: "",
      simpleSelect2: "",
      simpleSelect3: "",
      multipleSelect: [],
      tags: ["pizza", "pasta", "parmesan"]
    };
    this.handleTags = this.handleTags.bind(this);
  }
  handleSimple = event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  handleSimple1= event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  handleSimple2= event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  handleSimple3= event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  handleSimple4= event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  handleMultiple = event => {
    this.setState({ multipleSelect: event.target.value });
  };
  handleChange = name => event => {
    this.setState({ [name]: event.target.checked });
  };
  handleTags(regularTags) {
    this.setState({ tags: regularTags });
  }
  render() {
    const { classes } = this.props;
    return (
      <div className={classes.container}>
      <GridContainer>
        <GridItem xs={12} sm={12} md={8}>
            <GridContainer>
              <GridItem xs={12} sm={12} md={6}>
                <Card product className={`${classes.cardHover} ${classes.bgWarning}`}>
                  <CardHeader image className={classes.cardHeaderHover}>
                    <a href="#pablo" onClick={e => e.preventDefault()}>
                      <img src={priceImage1} alt="..." className={classes.imageSize} />
                      <div className={classes.dateDiv}>20</div>
                      <div className={classes.monthDiv}>Jun</div>
                    </a>
                  </CardHeader>
                  <CardBody>
                    <div className={`${classes.stats}`}>
                      <h4 className={`${classes.vatPrice}`}><a href="#pablo" onClick={e => e.preventDefault()}>New Age Plastics</a><br/>Johannesburg</h4>
                    </div>
                    <h4 className={classes.cardProductTitle}>
                      <a href="#pablo" onClick={e => e.preventDefault()}>
                        New Age Plastics
                      </a>
                    </h4>
                    <p className={classes.cardProductDesciprion}>
                      Chemicals<br/>
                      Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b...
                    </p>
                  </CardBody>
                  <CardFooter product>
                    <Button color="default" size="sm" round className={classes.marginRight}>
                      read more
                    </Button>
                    <Button color="danger" size="sm" round className={classes.marginRight}>
                      contact business
                    </Button>
                  </CardFooter>
                </Card>
              </GridItem>
              <GridItem xs={12} sm={12} md={6}>
                <Card product className={`${classes.cardHover} ${classes.bgWarning}`}>
                  <CardHeader image className={classes.cardHeaderHover}>
                    <a href="#pablo" onClick={e => e.preventDefault()}>
                      <img src={priceImage1} alt="..." className={classes.imageSize} />
                      <div className={classes.dateDiv}>20</div>
                      <div className={classes.monthDiv}>Jun</div>
                    </a>
                  </CardHeader>
                  <CardBody>
                    <div className={`${classes.stats}`}>
                      <h4 className={`${classes.vatPrice}`}><a href="#pablo" onClick={e => e.preventDefault()}>New Age Plastics</a><br/>Johannesburg</h4>
                    </div>
                    <h4 className={classes.cardProductTitle}>
                      <a href="#pablo" onClick={e => e.preventDefault()}>
                        New Age Plastics
                      </a>
                    </h4>
                    <p className={classes.cardProductDesciprion}>
                      Chemicals<br/>
                      Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b...
                    </p>
                  </CardBody>
                  <CardFooter product>
                    <Button color="default" size="sm" round className={classes.marginRight}>
                      read more
                    </Button>
                    <Button color="danger" size="sm" round className={classes.marginRight}>
                      contact business
                    </Button>
                  </CardFooter>
                </Card>
              </GridItem>  
              <GridItem xs={12} sm={12} md={6}>
                <Card product className={`${classes.cardHover} ${classes.bgWarning}`}>
                  <CardHeader image className={classes.cardHeaderHover}>
                    <a href="#pablo" onClick={e => e.preventDefault()}>
                      <img src={priceImage1} alt="..." className={classes.imageSize} />
                      <div className={classes.dateDiv}>20</div>
                      <div className={classes.monthDiv}>Jun</div>
                    </a>
                  </CardHeader>
                  <CardBody>
                    <div className={`${classes.stats}`}>
                      <h4 className={`${classes.vatPrice}`}><a href="#pablo" onClick={e => e.preventDefault()}>New Age Plastics</a><br/>Johannesburg</h4>
                    </div>
                    <h4 className={classes.cardProductTitle}>
                      <a href="#pablo" onClick={e => e.preventDefault()}>
                        New Age Plastics
                      </a>
                    </h4>
                    <p className={classes.cardProductDesciprion}>
                      Chemicals<br/>
                      Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b...
                    </p>
                  </CardBody>
                  <CardFooter product>
                    <Button color="default" size="sm" round className={classes.marginRight}>
                      read more
                    </Button>
                    <Button color="danger" size="sm" round className={classes.marginRight}>
                      contact business
                    </Button>
                  </CardFooter>
                </Card>
              </GridItem>  
              <GridItem xs={12} sm={12} md={6}>
                <Card product className={`${classes.cardHover} ${classes.bgWarning}`}>
                  <CardHeader image className={classes.cardHeaderHover}>
                    <a href="#pablo" onClick={e => e.preventDefault()}>
                      <img src={priceImage1} alt="..." className={classes.imageSize} />
                      <div className={classes.dateDiv}>20</div>
                      <div className={classes.monthDiv}>Jun</div>
                    </a>
                  </CardHeader>
                  <CardBody>
                    <div className={`${classes.stats}`}>
                      <h4 className={`${classes.vatPrice}`}><a href="#pablo" onClick={e => e.preventDefault()}>New Age Plastics</a><br/>Johannesburg</h4>
                    </div>
                    <h4 className={classes.cardProductTitle}>
                      <a href="#pablo" onClick={e => e.preventDefault()}>
                        New Age Plastics
                      </a>
                    </h4>
                    <p className={classes.cardProductDesciprion}>
                      Chemicals<br/>
                      Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b...
                    </p>
                  </CardBody>
                  <CardFooter product>
                    <Button color="default" size="sm" round className={classes.marginRight}>
                      read more
                    </Button>
                    <Button color="danger" size="sm" round className={classes.marginRight}>
                      contact business
                    </Button>
                  </CardFooter>
                </Card>
              </GridItem>          
            </GridContainer>
            <GridContainer direction="row" justify="center" alignItems="flex-start">
              <GridItem>
                <div className={classes.naviCenter}>
                  <Pagination
                    pages={[
                      { text: "PREV" },
                      // { text: "..." },
                      { active: true, text: 1 },
                      { text: 2 },
                      { text: 3 },
                      { text: 4 },
                      { text: 5 },
                      { text: 6 },
                      { text: 7 },
                      { text: 8 },
                      { text: 9 },
                      { text: "..." },
                      { text: "NEXT" }
                    ]}
                    color="danger"
                  />
                </div>
              </GridItem>
            </GridContainer>
        </GridItem>         
        <GridItem xs={12} sm={12} md={4}>
          <Card>
            <CardHeader color="success" icon>
              <CardIcon color="success">
                <h4 className={classes.cardTitleWhite}>SEARCH FILTERS</h4>
              </CardIcon>
              <CardBody>
                <form>
                  <GridContainer>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <CustomInput 
                        success={this.state.firstnameState === "success"}
                        error={this.state.firstnameState === "error"}
                        labelText={<span>Title</span>}
                        id="Enter Special Title"
                        formControlProps={{fullWidth: true}} 
                      />
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor="simple-select" className={classes.selectLabel}>All Companies</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state.simpleSelect} onChange={this.handleSimple}
                          inputProps={{name: "simpleSelect", id: "simple-select"}}>
                          <MenuItem disabled classes={{root: classes.selectMenuItem}}>All Companies</MenuItem>
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="1">New Age Plastics</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="2">Rosh Products Manufacturers (Pty) Ltd</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="3">Statfurn cc</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="4">Speedchem</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="5">WASAA</MenuItem> 
                        </Select>
                      </FormControl>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor="simple-select1" className={classes.selectLabel}>All Category</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state.simpleSelect1} onChange={this.handleSimple1}
                          inputProps={{name: "simpleSelect1", id: "simple-select1"}}>
                          <MenuItem disabled classes={{root: classes.selectMenuItem}}>All Category</MenuItem>
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="1">Paris</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="2">Roma</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="3">Tokyo</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="4">Beijing</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="5">Moscow</MenuItem> 
                        </Select>
                      </FormControl>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor="simple-select1" className={classes.selectLabel}>All Province</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state.simpleSelect1} onChange={this.handleSimple1}
                          inputProps={{name: "simpleSelect1", id: "simple-select1"}}>
                          <MenuItem disabled classes={{root: classes.selectMenuItem}}>All Province</MenuItem>
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="1">Eastern Cape</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="2">Free State</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="3">Gauteng</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="4">KwaZulu Natal</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="5">Limpopo</MenuItem> 
                        </Select>
                      </FormControl>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor="simple-select2" className={classes.selectLabel}>All City</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state.simpleSelect2} onChange={this.handleSimple2}
                          inputProps={{name: "simpleSelect2", id: "simple-select2"}}>
                          <MenuItem disabled classes={{root: classes.selectMenuItem}}>All City</MenuItem>
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="1">Alberton</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="2">Alexander Bay</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="3">Allen Grove</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="4">Amanzimtoti</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="5">Amanzimtoti</MenuItem> 
                        </Select>
                      </FormControl>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor="simple-select3" className={classes.selectLabel}>All Suburb</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state.simpleSelect3} onChange={this.handleSimple3}
                          inputProps={{name: "simpleSelect3", id: "simple-select3"}}>
                          <MenuItem disabled classes={{root: classes.selectMenuItem}}>All Suburb</MenuItem>
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="1">11 Urtel Rd</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="2">138 Main Reef Rd</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="3">22</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="4">236 Zambezi Drive</MenuItem> 
                          <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value="5">3 Dynagel St</MenuItem> 
                        </Select>
                      </FormControl>
                    </GridItem>
                    <GridItem xs={12} sm={12} md={12} lg={12}>
                      <div style={{height: "100%", textAlign: "center"}}>
                        <Button color="danger" round>Search</Button>
                      </div>
                    </GridItem>
                  </GridContainer>  
                </form>
              </CardBody>            
            </CardHeader>
          </Card>
        </GridItem> 
      </GridContainer>
      </div>
    );
  }
}

SpecialsPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(specialsPageStyle)(SpecialsPage);
