import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import Button from "components/CustomButtons/Button.jsx";
import Card from "components/Card/Card.jsx";
import CardHeader from "components/Card/CardHeader.jsx";
import CardBody from "components/Card/CardBody.jsx";
import CardFooter from "components/Card/CardFooter.jsx";

import athenaManufacturingCardStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaManufacturingCardStyle.jsx";

class AthenaManufacturingCard extends React.Component {

  render() {
    const { classes, athenaImage, athenaDay, athenaMonth, athenaCompany, athenaSuburb, athenaCategory, athenaDescription} = this.props;
    return (
      <Card product className={`${classes.cardHover} ${classes.bgWarning}`}>
        <CardHeader image className={classes.cardHeaderHover}>
          <a className={classes.aColor} href="#pablo" onClick={e => e.preventDefault()}>
            <img src={athenaImage} alt="..." className={classes.imageSize} />
            <div className={classes.dateDiv}>{athenaDay}</div>
            <div className={classes.monthDiv}>{athenaMonth}</div>
          </a>
        </CardHeader>
        <CardBody>
          <div className={classes.stats}>
            <h4 className={classes.vatPrice}><a href="#pablo" onClick={e => e.preventDefault()}>{athenaCompany}</a><br/>{athenaSuburb}</h4>
          </div>
          <h4 className={classes.cardProductTitle}>
            <a className={classes.redColor} href="#pablo" onClick={e => e.preventDefault()} title={athenaCompany}>
              {athenaCompany.length > 30 ? athenaCompany.substring(0, 30) + "...": athenaCompany}
            </a>
          </h4>
          <p className={classes.cardProductDesciprion}>
            {athenaCategory}<br/>
            {athenaDescription}
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
    );
  }
}

AthenaManufacturingCard.propTypes = {
  classes: PropTypes.object.isRequired,
  athenaImage: PropTypes.string,
  athenaDay: PropTypes.string,
  athenaMonth: PropTypes.string,
  athenaCompany: PropTypes.string,
  athenaSuburb: PropTypes.string,
  athenaCategory: PropTypes.string,
  athenaDescription: PropTypes.string,
};

export default withStyles(athenaManufacturingCardStyle)(AthenaManufacturingCard);
