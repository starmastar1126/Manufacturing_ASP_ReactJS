import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";

// core components
import GridContainer from "components/Grid/GridContainer.jsx";
import GridItem from "components/Grid/GridItem.jsx";

import manufacturingCompaniesPageStyle from "assets/jss/material-dashboard-pro-react/athena/manufacturingCompaniesPageStyle.jsx";

import priceImage1 from "assets/img/product/1165798681_16-06-2015_16_37_8.png";
import priceImage3 from "assets/img/product/no-image.jpg";
import priceImage2 from "assets/img/product/1217899245_16-06-2015_17_14_3.jpg";
import Pagination from "components/Pagination/Pagination.jsx";

import AthenaManufacturingCard from "components/Athena/AthenaManufacturingCard.jsx";
import AthenaSearchCard from "components/Athena/AthenaSearchCard.jsx";

const data = [
  {
    athenaIndex: "1", 
    athenaImage: priceImage1,
    athenaDay: "20",
    athenaMonth: "Jun",
    athenaCompany: "New Age Plastics",
    athenaSuburb: "Johannesburg",
    athenaCategory: "Chemicals",
    athenaDescription: "Manufacture and distributors of PET, Injected Moulded and Blow Moulded products. New Age Plastics has grown considerably since it was established in 1991 and has always b..."
  },
  {
    athenaIndex: "2",
    athenaImage: priceImage2,
    athenaDay: "16",
    athenaMonth: "Jun",
    athenaCompany: "Rosh Products Manufacturers (Pty) Ltd",
    athenaSuburb: "Johannesburg",
    athenaCategory: "Chemicals",
    athenaDescription: "Manufacturers of Detergines and food processed products."
  },
  {
    athenaIndex: "3",
    athenaImage: priceImage3,
    athenaDay: "28",
    athenaMonth: "Jun",
    athenaCompany: "Statfurn cc",
    athenaSuburb: "Johannesburg",
    athenaCategory: "Textiles, Clothing and Footwear",
    athenaDescription: ""
  },
  {
    athenaIndex: "4",
    athenaImage: priceImage3,
    athenaDay: "3",
    athenaMonth: "Jul",
    athenaCompany: "Speedchem",
    athenaSuburb: "Johannesburg",
    athenaCategory: "Metals",
    athenaDescription: ""
  }
]

const search = [
  {
    athenaSearch: "Search by Company",
    athenaCombo: [
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
      },
      {
        comboId: "manufacturing-select",
        comboName: "manufacturingSelect",
        comboTitle: "All Manufacturing",
        comboContent: [
          {
            index: "0",
            content: "All Manufacturing"
          },
          {
            index: "1",
            content: "Aerospace  and  Defense"
          },
          {
            index: "2",
            content: "Arts  and  Grafts"
          },
          {
            index: "3",
            content: "Automotive Manufacturers"
          },
          {
            index: "4",
            content: "Chemicals"
          }
        ]
      },

    ]
  }
]

class ManufacturingCompaniesPage extends React.Component {

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
                <GridItem xs={12} sm={12} md={4}>
                  <AthenaManufacturingCard
                    athenaImage = {item.athenaImage}
                    athenaDay = {item.athenaDay}
                    athenaMonth = {item.athenaMonth}
                    athenaCompany = {item.athenaCompany}
                    athenaSuburb = {item.athenaSuburb}
                    athenaCategory = {item.athenaCategory}
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

ManufacturingCompaniesPage.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(manufacturingCompaniesPageStyle)(ManufacturingCompaniesPage);
