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

import athenaDigitalCardStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaDigitalCardStyle.jsx";

class AthenaDigitalCard extends React.Component {

  render() {
    const { classes, athenaImage, athenaDay, athenaMonth, athenaCatalogue, athenaIndustrial, athenaTitle, athenaDescription} = this.props;
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
          <br/><br/>
          <div className={classes.stats}>
            <h4 className={classes.namePrice}><a href="#pablo" onClick={e => e.preventDefault()}>{athenaCatalogue}</a></h4>
            <h4 className={`${classes.realPrice}`}>|&nbsp;&nbsp;&nbsp;{athenaIndustrial}&nbsp;&nbsp;&nbsp;|</h4>
          </div>
          <h4 className={classes.cardProductTitle}>
            <a href="#pablo" onClick={e => e.preventDefault()}>
              {athenaTitle}
            </a>
          </h4>
          <p className={classes.cardProductDesciprion}>
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

AthenaDigitalCard.propTypes = {
  classes: PropTypes.object.isRequired,
  athenaImage: PropTypes.string,
  athenaDay: PropTypes.string,
  athenaMonth: PropTypes.string,
  athenaCatalogue: PropTypes.string,
  athenaIndustrial: PropTypes.string,
  athenaTitle: PropTypes.string,
  athenaDescription: PropTypes.string,
};

export default withStyles(athenaDigitalCardStyle)(AthenaDigitalCard);
