import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// @material-ui/icons

// core components
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";

import digitalCataloguesPageStyle from "assets/jss/material-dashboard-pro-react/athena/digitalCataloguesPageStyle.jsx";

import priceImage1 from "assets/img/product/EZYCATIMG_1313_4241_2_2018_02_06.jpg";
import priceImage2 from "assets/img/dc-2.jpg";
import Pagination from "components/Pagination/Pagination.jsx";

import AthenaDigitalCard from "components/Athena/AthenaDigitalCard.jsx";
import AthenaSearchCard from "components/Athena/AthenaSearchCard.jsx";

const data = [
  {
    athenaIndex: "1", 
    athenaImage: priceImage1,
    athenaDay: "20",
    athenaMonth: "Jun",
    athenaCatalogue: "E-Catalogue by Abel Equipment",
    athenaIndustrial: "George Industrial",
    athenaTitle: "Abel Equipment - affordable brick m...",
    athenaDescription: "Satisfied clients are proof of the quality and scope of Abel Equipment relationship with the concrete building component industry"
  },
  {
    athenaIndex: "2", 
    athenaImage: priceImage2,
    athenaDay: "20",
    athenaMonth: "Jun",
    athenaCatalogue: "E-Catalogue by Abel Equipment",
    athenaIndustrial: "Johannesburg",
    athenaTitle: "Chemicals",
    athenaDescription: "Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b..."
  },
]

const search = [
  {
    athenaSearch: "Enter E-Catalogue Title",
    athenaCombo: [
      {
        comboId: "company-select",
        comboName: "companySelect",
        comboTitle: "All Companies",
        comboContent: [
          {
            index: "0",
            content: "All Companies"
          },
          {
            index: "1",
            content: "New Age Plastics"
          },
          {
            index: "2",
            content: "Rosh Products Manufacturers (Pty) Ltd"
          },
          {
            index: "3",
            content: "Statfurn cc"
          },
          {
            index: "4",
            content: "Speedchem"
          }
        ]
      },
      {
        comboId: "province-select",
        comboName: "provinceSelect",
        comboTitle: "All Province",
        comboContent: [
          {
            index: "0",
            content: "All Province"
          },
          {
            index: "1",
            content: "Eastern Cape"
          },
          {
            index: "2",
            content: "Free State"
          },
          {
            index: "3",
            content: "Gauteng"
          },
          {
            index: "4",
            content: "KwaZulu Natal"
          }
        ]
      },
      {
        comboId: "city-select",
        comboName: "citySelect",
        comboTitle: "All City",
        comboContent: [
          {
            index: "0",
            content: "All City"
          },
          {
            index: "1",
            content: "Alberton"
          },
          {
            index: "2",
            content: "Alexander Bay"
          },
          {
            index: "3",
            content: "Allen Grove"
          },
          {
            index: "4",
            content: "Amanzimtoti"
          }
        ]
      },
      {
        comboId: "suburb-select",
        comboName: "suburbSelect",
        comboTitle: "All Suburb",
        comboContent: [
          {
            index: "0",
            content: "All Suburb"
          },
          {
            index: "1",
            content: "11 Urtel Rd"
          },
          {
            index: "2",
            content: "138 Main Reef Rd"
          },
          {
            index: "3",
            content: "236 Zambezi Drive"
          },
          {
            index: "4",
            content: "366 Victoria Road"
          }
        ]
      }
    ]
  }
]

class DigitalCataloguesPage extends React.Component {

  render() {
    const { classes } = this.props;
    return (
      <div className={classes.container}>
        {search.map((comboItem, comboKey) => {
          return (
            <AthenaSearchCard
              athenaSearch = {comboItem.athenaSearch}
              athenaCombo = {comboItem.athenaCombo}
            />
          );
        })} 
      <GridContainer>
        {data.map((item, key) => {
          return (
            <GridItem xs={12} sm={12} md={6}>
              <AthenaDigitalCard
                athenaImage = {item.athenaImage}
                athenaDay = {item.athenaDay}
                athenaMonth = {item.athenaMonth}
                athenaCatalogue = {item.athenaCatalogue}
                athenaIndustrial = {item.athenaIndustrial}
                athenaTitle = {item.athenaTitle}
                athenaDescription = {item.athenaDescription}
              />
            </GridItem>  
          );}                      
        )}           
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
      </div>
    );
  }
}

DigitalCataloguesPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(digitalCataloguesPageStyle)(DigitalCataloguesPage);
