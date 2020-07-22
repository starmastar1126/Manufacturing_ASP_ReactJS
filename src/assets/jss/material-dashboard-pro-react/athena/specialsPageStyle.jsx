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
import hoverCardStyle from "assets/jss/material-dashboard-pro-react/hoverCardStyle.jsx";

const specialsPageStyle = theme => ({
  ...customSelectStyle,
  ...hoverCardStyle,
  container: {
    ...container,
    zIndex: "4",
    marginTop: "50px",
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
  cardTitle: {
    ...cardTitle,
    marginTop: "0px",
    marginBottom: "3px"
  },
  cardIconTitle: {
    ...cardTitle,
    marginTop: "15px",
    marginBottom: "0px"
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
    fontSize: "16px",
    width: "50%",
  },
  realPrice: {
    fontSize: "16px",
    color: "#cc0000",
    width: "50%",
    textAlign: "right"
  },
  vatPrice: {
    fontSize: "12px",
    fontStyle: "italic"
  },
  cardProductTitle: {
    // ...cardTitle,
    height: "30px",    
    marginTop: "0px",
    marginBottom: "3px",
    fontWeight: "900"
    // textAlign: "center"
  },
  cardProductDesciprion: {
    height: "80px",    
    overflow: "hidden",
    color: grayColor[0]
  },
  naviCenter: {
    textAlign: "center"
  },
  imageSize: {
    width: "100vw",
    height: "25vh",
  },
  cardHover: {
    "&:hover": {
      "& $cardHeaderHover": {
        transform: "translate3d(0, -20px, 0)"
      }
    }
  },
  cardHeaderHover: {
    transition: "all 300ms cubic-bezier(0.34, 1.61, 0.7, 1)",
  },
  cardHoverUnder: {
    position: "absolute",
    zIndex: "1",
    top: "-50px",
    width: "calc(100% - 30px)",
    left: "17px",
    right: "17px",
    textAlign: "center"
  },
  bgWarning: {
    backgroundColor: whiteColor,
    // backgroundColor: grayColor[5]
  },
  searchBtnDiv: {
    width: "100%",
    height: "100%",
    textAlign: "left",
    paddingBottom: "30px"
  },
  dateDiv: {
    width: "30px",
    height: "30px",
    position: "absolute",
    textAlign: "center",
    paddingTop: "5px",
    left: "0px",
    top: "0px",
    backgroundColor: "#E0291D",
    color: "#FFFFFF",
    fontSize: "12px",
    fontWeight: "500"
  },
  monthDiv: {
    width: "30px",
    height: "30px",
    position: "absolute",
    textAlign: "center",
    paddingTop: "5px",
    left: "0px",
    top: "30px",
    backgroundColor: "#CD2323",
    color: "#FFFFFF",
    fontSize: "12px",
    fontWeight: "500"
  }
});

export default specialsPageStyle;
