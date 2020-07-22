import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

import listYourBusinessPageStyle from "assets/jss/material-dashboard-pro-react/athena/listYourBusinessPageStyle.jsx";

import AthenaWizard from "components/Athena/AthenaWizard.jsx";
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";

import listYourBusinessStep from "views/Athena/listYourBusinessStep.jsx";

const step1Date = {
  

}
class ListYourBusinessPage extends React.Component {

  render() {
    const { classes } = this.props;
    
    return (
      <div className={classes.container}>
        <GridContainer justify="center">
        <GridItem xs={12} sm={12}>
          <AthenaWizard
            steps={[
              { stepName: "1 Month", stepComponent: listYourBusinessStep, stepId: "step1" },
              { stepName: "3 Month(5% OFF)", stepComponent: listYourBusinessStep, stepId: "step2" },
              { stepName: "6 Month(10% OFF)", stepComponent: listYourBusinessStep, stepId: "step3" },
              { stepName: "9 Month(15% OFF)", stepComponent: listYourBusinessStep, stepId: "step4" }
            ]}
            title="SELECT SUBSCRIPTION PLAN"
            subtitle="This information will let us know more about you."
            finishButtonClick={e => console.log(e)}
          />
        </GridItem>
      </GridContainer>
      </div>
    );
  }
}

ListYourBusinessPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(listYourBusinessPageStyle)(ListYourBusinessPage);
