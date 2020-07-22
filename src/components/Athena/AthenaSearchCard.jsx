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
import CardIcon from "components/Card/CardIcon.jsx";
import CardBody from "components/Card/CardBody.jsx";
import CustomInput from "components/CustomInput/CustomInput.jsx";
import FormControl from "@material-ui/core/FormControl";
import InputLabel from "@material-ui/core/InputLabel";
import Select from "@material-ui/core/Select";
import MenuItem from "@material-ui/core/MenuItem";

import athenaSearchCardStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaSearchCardStyle.jsx";

class AthenaSearchCard extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      companySelect: "",
      provinceSelect: "",
      citySelect: "",
      suburbSelect: "",
      manufacturingSelect: ""
    };
  }    
  handleSimple = event => {
    this.setState({ [event.target.name]: event.target.value });
  };
  render() {
    const { classes, athenaSearch, athenaCombo} = this.props;
    return (
      <Card>
        <CardHeader color="success" icon>
          <CardIcon color="success">
            <h4 className={classes.cardTitleWhite}>SEARCH FILTERS</h4>
          </CardIcon>
          <CardBody>
            <form>
              <GridContainer>
                <GridItem xs={12} sm={12} md={2} lg={2}>
                  <CustomInput 
                    success={this.state.firstnameState === "success"}
                    error={this.state.firstnameState === "error"}
                    labelText={<span>{athenaSearch}</span>}
                    id="searchCompany"
                    formControlProps={{fullWidth: true}} 
                  />
                </GridItem>
                {athenaCombo.map((item, key) =>{
                  return (
                    <GridItem xs={12} sm={12} md={2} lg={2}>
                      <FormControl fullWidth className={classes.selectFormControl}>
                        <InputLabel htmlFor={item.comboId} className={classes.selectLabel}>{item.comboTitle}</InputLabel>
                        <Select MenuProps={{className: classes.selectMenu}} classes={{select: classes.select}}
                          value={this.state[item.comboName]} onChange={this.handleSimple}
                          inputProps={{name: item.comboName, id: item.comboId}}>
                          {/* <MenuItem disabled classes={{root: classes.selectMenuItem}}>{item.comboTitle}</MenuItem> */}
                          {item.comboContent.map((menuItem, menuKey) =>{
                            return (
                              <MenuItem classes={{root: classes.selectMenuItem, selected: classes.selectMenuItemSelected}} value={menuItem.index}>{menuItem.content}</MenuItem> 
                            );} 
                          )}
                        </Select>
                      </FormControl>
                    </GridItem>
                  );}
                )}                
                <GridItem xs={12} sm={12} md={2} lg={2}>
                  <div style={{height: "100%", verticalAlign: "text-bottom"}}>
                    <Button color="danger" round>Search</Button>
                  </div>
                </GridItem>
              </GridContainer>  
            </form>
          </CardBody>            
        </CardHeader>
      </Card>
    );
  }
}

AthenaSearchCard.propTypes = {
  classes: PropTypes.object.isRequired,
  athenaSearch: PropTypes.string,
  athenaCombo: PropTypes.array,
};

export default withStyles(athenaSearchCardStyle)(AthenaSearchCard);
