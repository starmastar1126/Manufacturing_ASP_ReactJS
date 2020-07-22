import React from 'react';

import Banner from '../components/Banner'
import Select from '../components/Select'
import MagazinesCard from '../components/MagazinesCard'
import Pagenation from '../components/Pagenation'
import StockCa from '../components/StockCa'

import bgImage from "../assets/img/magazin_banner.jpeg"
import magaginImage1 from "../assets/img/magagin21.jpg"
import magaginImage2 from "../assets/img/magagin23.jpg"
import magaginImage3 from "../assets/img/magagin24.jpg"
import magaginImage4 from "../assets/img/ma.jpg"

import requestPng from '../assets/img/request_tyres_side.png'
import RequestItem from '../components/RequestItem.js'

const magazinesCardData = [
  {
    index: "1", 
    image: magaginImage1,
    fromDate: "16 Feb",
    toDate: "18 Feb",
    company: "E-Catalogue by 3 M South Africa Pty Ltd E-Catalogue by 3 M South Africa Pty Ltd",
    suburb: "Johannesburg Johannesburg",
    category: "simply dummy text E-Catalogue by 3 M South Africa Pty Ltd E-Catalogue by 3 M South Africa Pty Ltd",
    description: "Sed ut perspiciatis unde omnis iste natus error sit volup tatem accu san tium dolo remque laudan tium, totam rem aperiam."
  },
  {
    index: "2",
    image: magaginImage2,
    fromDate: "16 Feb",
    toDate: "18 Feb",
    company: "Rosh Products Manufacturers (Pty) Ltd",
    suburb: "Johannesburg",
    category: "Chemicals",
    description: "Manufacturers of Detergines and food processed products."
  },
  {
    index: "3",
    image: magaginImage3,
    fromDate: "16 Feb",
    toDate: "18 Feb",
    company: "Statfurn cc",
    suburb: "Johannesburg",
    category: "Textiles, Clothing and Footwear",
    description: ""
  },
  {
    index: "4",
    image: magaginImage4,
    fromDate: "16 Feb",
    toDate: "18 Feb",
    company: "Speedchem",
    suburb: "Johannesburg",
    category: "Metals",
    description: ""
  }
]

const selectData = [
  {
    index: "1",
    options: [
      {
        value: '1',
        content: 'Select Company'
      },
      {
        value: '2',
        content: 'One Company'
      }
    ]
  },
  {
    index: "2",
    options: [
      {
        value: "0",
        content: "All Province"
      },
      {
        value: "1",
        content: "Eastern Cape"
      },
      {
        value: "2",
        content: "Free State"
      },
      {
        value: "3",
        content: "Gauteng"
      },
      {
        value: "4",
        content: "KwaZulu Natal"
      }
    ]
  },
  {
    index: "3",
    options: [
      {
        value: "0",
        content: "All City"
      },
      {
        value: "1",
        content: "Alberton"
      },
      {
        value: "2",
        content: "Alexander Bay"
      },
      {
        value: "3",
        content: "Allen Grove"
      },
      {
        value: "4",
        content: "Amanzimtoti"
      }
    ]
  },
  {
    index: "4",
    options: [
      {
        value: "0",
        content: "All Suburb"
      },
      {
        value: "1",
        content: "11 Urtel Rd"
      },
      {
        value: "2",
        content: "138 Main Reef Rd"
      },
      {
        value: "3",
        content: "236 Zambezi Drive"
      },
      {
        value: "4",
        content: "366 Victoria Road"
      }
    ]
  },
  {
    index: "5",
    options: [
      {
        value: "0",
        content: "All Manufacturing"
      },
      {
        value: "1",
        content: "Aerospace  and  Defense"
      },
      {
        value: "2",
        content: "Arts  and  Grafts"
      },
      {
        value: "3",
        content: "Automotive Manufacturers"
      },
      {
        value: "4",
        content: "Chemicals"
      }
    ]
  },
]

const pagenationData = [
  {
    i: "1", 
    active: false
  },
  {
    i: "2", 
    active: false
  },
  {
    i: "3", 
    active: true
  },
  {
    i: "4", 
    active: false
  },
  {
    i: "5", 
    active: false
  },
  {
    i: "...", 
    active: false
  },
  {
    i: "25", 
    active: false
  },
]

const stockCaData = [
  {
    index: "1",
    content: "Manufacturing Companies in City of Johannesburg Metropolitan Municipality"
  },
  {
    index: "2",
    content: "Kolkata"
  },
  {
    index: "3",
    content: "Mumbai"
  }
]

class ViewMagazinesPage extends React.Component {
  constructor(props) {
      super(props);
      this.state = {
        showHideRequestItemState: false
      };
      this.showHideRequestItemDialog = this.showHideRequestItemDialog.bind(this);
  }

  showHideRequestItemDialog(){
    const { showHideRequestItemState } = this.state;
    if(showHideRequestItemState === false){
      this.setState({showHideRequestItemState: true});
    } else {
      this.setState({showHideRequestItemState: false})
    }
  }
  render() {
    return (
      <div>
        <Banner
          bgImage = {bgImage}
          title = {'View Magazines'}
        />
        <section class="viewspecial magazin_list_page">
          <div class="container">
            <div class="topview topview_add clearfix">
              <h1>Search Filters</h1>
              <ul>
                {selectData.map((selectItem, selectKey) => {
                  return (
                    <li>
                      <div class={"sel_col"}>
                        <Select
                          index = {selectItem.index}
                          classes = "selectpicker"
                          options = {selectItem.options}
                        />
                        <i class="dropp_arrow"></i>
                      </div>
                    </li>
                  );}                      
                )}      
                <li>
                  <input class="input_search" type="submit" name="" id="" value="search"/>
                </li>                
              </ul>
            </div>
                               
            <div class="search_list viewspecial_magazin">
              <div class="row">
                <div class="col-md-12">
                  <div class="row">
                    {magazinesCardData.map((magazinesCardItem, magazinesCardKey) => {
                      return (
                        <MagazinesCard
                          index = {magazinesCardItem.index}
                          fromDate = {magazinesCardItem.fromDate}
                          toDate = {magazinesCardItem.toDate}
                          image = {magazinesCardItem.image}
                          company = {magazinesCardItem.company}
                          suburb = {magazinesCardItem.suburb}
                          category = {magazinesCardItem.category}
                          description = {magazinesCardItem.description}
                        />
                      );}                      
                    )}    
                  </div>                    
                  <Pagenation
                    count = {pagenationData}
                  />                
                </div>
              </div>
            </div>
          </div>
        </section>

        {/* <StockCa
          title = {'Manufacturing Companies in South Africa'}
          list = {stockCaData}
        /> */}
        <a onClick={this.showHideRequestItemDialog} id="menu-toggle"><img src={requestPng} alt=""/></a>
        <RequestItem showHideProps={this.state.showHideRequestItemState} />
      </div>
    );
  }
}

export default ViewMagazinesPage;
                   