import {
  grayColor,
  whiteColor
} from "assets/jss/material-dashboard-pro-react.jsx";

const athenaDigitalCardStyle = theme => ({
  
  cardHover: {
    "&:hover": {
      "& $cardHeaderHover": {
      }
    }
  },
  cardHeaderHover: {
    transform: "translate3d(0, 50px, 0)"
  },
  cardHoverUnder: {
    position: "absolute",
    zIndex: "1",
    width: "calc(100% - 30px)",
    left: "17px",
    right: "17px",
    textAlign: "center"
  },
  bgWarning: {
    backgroundColor: whiteColor,
  },
  imageSize: {
    width: "100vw",
    height: "40vh",
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
  },
  stats: {
    width: "100%",
    lineHeight: "12px",
    display: "inline-flex",
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
  cardProductTitle: {
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
  redColor: {
    color: "rgba(180, 0, 0, 1)"
  },
  aColor: {
    fontSize: "12px",
    color: "rgba(0, 0, 0, 0.6)",
    fontFamily: "Open Sans, sans-serif"
  }
});

export default athenaDigitalCardStyle;
