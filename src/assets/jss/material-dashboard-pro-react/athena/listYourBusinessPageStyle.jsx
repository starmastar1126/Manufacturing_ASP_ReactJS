import {
  container,
  defaultFont,
  cardTitle,
  roseColor,
  whiteColor,
  grayColor,
  hexToRgb
} from "assets/jss/material-dashboard-pro-react.jsx";
import customSelectStyle from "assets/jss/material-dashboard-pro-react/customSelectStyle.jsx";

const listYourBusinessPageStyle = theme => ({
  ...customSelectStyle,
  // ...hoverCardStyle,
  container: {
    ...container,
    marginTop: "20px",
    zIndex: "4",
    [theme.breakpoints.down("sm")]: {
      paddingBottom: "100px"
    }
  },
  title: {
    ...defaultFont,
    color: whiteColor,
    marginTop: "5vh",
    marginBottom: "30px",
    textAlign: "center"
  },
  description: {
    fontSize: "18px",
    color: whiteColor,
    textAlign: "center"
  },
cardTitleWhite: {
  ...cardTitle,
  color: whiteColor + " !important"
},
cardCategory: {
  color: grayColor[0],
  marginTop: "10px"
},
cardCategoryWhite: {
  color: whiteColor,
  marginTop: "10px"
},
icon: {
  color: "rgba(" + hexToRgb(whiteColor) + ", 0.76)",
  margin: "10px auto 0",
  width: "130px",
  height: "130px",
  border: "1px solid " + grayColor[11],
  borderRadius: "50%",
  lineHeight: "174px",
  "& svg": {
    width: "55px",
    height: "55px"
  },
  "& .fab,& .fas,& .far,& .fal,& .material-icons": {
    width: "55px",
    fontSize: "55px"
  }
},
  iconWhite: {
    color: whiteColor
  },
  iconRose: {
    color: roseColor[0]
  },
  marginTop30: {
    marginTop: "30px"
  },
  // cardTitle,
  // cardTitleWhite: {
  //   ...cardTitle,
  //   color: "#FFFFFF",
  //   marginTop: "0"
  // },
  // cardCategoryWhite: {
  //   margin: "0",
  //   color: "rgba(255, 255, 255, 0.8)",
  //   fontSize: ".875rem"
  // },
  // cardCategory: {
  //   color: "#999999",
  //   marginTop: "10px"
  // },
  // icon: {
  //   color: "#333333",
  //   margin: "10px auto 0",
  //   width: "130px",
  //   height: "130px",
  //   border: "1px solid #E5E5E5",
  //   borderRadius: "50%",
  //   lineHeight: "174px",
  //   "& svg": {
  //     width: "55px",
  //     height: "55px"
  //   },
  //   "& .fab,& .fas,& .far,& .fal,& .material-icons": {
  //     width: "55px",
  //     fontSize: "55px"
  //   }
  // },
  testimonialIcon: {
    marginTop: "30px",
    "& svg": {
      width: "40px",
      height: "40px"
    }
  },
  cardTestimonialDescription: {
    fontStyle: "italic",
    color: "#999999"
  },
  productStats: {
    paddingTop: "7px",
    paddingBottom: "7px",
    margin: "0"
  },
  price: {
    color: "inherit",
    "& h4": {
      marginBottom: "0px",
      marginTop: "0px"
    }
  },
  stats: {
    // color: grayColor[0],
    width: "100%",
    lineHeight: "12px",
    display: "inline-flex",
    // "& svg": {
    //   position: "relative",
    //   top: "4px",
    //   width: "16px",
    //   height: "16px",
    //   marginRight: "3px"
    // },
    // "& .fab,& .fas,& .far,& .fal,& .material-icons": {
    //   position: "relative",
    //   top: "4px",
    //   fontSize: "16px",
    //   marginRight: "3px"
    // }
  },
  namePrice: {
    fontSize: "12px",
    fontStyle: "italic",
    width: "70%",
    textAlign: "center"
  },
  realPrice: {
    fontSize: "12px",
    color: "#cc0000",
    width: "30%",
    textAlign: "left"
  },
  vatPrice: {
    fontSize: "12px",
    // fontStyle: "italic",
    textAlign: "center"
  },
  cardProductTitle: {
    // ...cardTitle,
    height: "30px",    
    marginTop: "0px",
    marginBottom: "3px",
    textAlign: "center",
    fontSize: "20px",
    fontWeight: "900"
  },
  cardProductDesciprion: {
    height: "80px",    
    overflow: "hidden",
    color: grayColor[0],
    textAlign: "center"
  },
  naviCenter: {
    textAlign: "center"
  },
  cardHover: {
    "&:hover": {
      "& $cardHeaderHover": {
        // transform: "translate3d(0, -50px, 0)"
        // transform: "translate3d(-50px, -50px, 0)"
      }
    }
  },
  cardHeaderHover: {
    // transition: "all 300ms cubic-bezier(0.34, 1.61, 0.7, 1)",
    transform: "translate3d(0, 50px, 0)"
  },
  cardHoverUnder: {
    position: "absolute",
    zIndex: "1",
    // top: "-50px",
    width: "calc(100% - 30px)",
    left: "17px",
    right: "17px",
    textAlign: "center"
  },
  bgWarning: {
    // backgroundColor: "rgba(" + hexToRgb('#ffffff') + ", 0.65)",
    backgroundColor: whiteColor,
    // backgroundColor: grayColor[5]
  },
  cardTitle1: {
    ...cardTitle,
    color: whiteColor + " !important"
  },
});

export default listYourBusinessPageStyle;
