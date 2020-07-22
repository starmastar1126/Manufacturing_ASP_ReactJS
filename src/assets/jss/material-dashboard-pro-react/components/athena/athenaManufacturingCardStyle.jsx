import {
  whiteColor
} from "assets/jss/material-dashboard-pro-react.jsx";

const athenaManufacturingCardStyle = theme => ({
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
  },
  imageSize: {
    width: "100vw",
    height: "25vh",
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
  vatPrice: {
    fontSize: "12px",
    fontStyle: "italic",
    lineHeight: "20px",
    color: "rgba(0, 0, 0, 0.6)",
    fontFamily: "Open Sans, sans-serif"
  },
  cardProductTitle: {
    height: "30px",    
    marginTop: "0px",
    marginBottom: "3px",
    fontWeight: "900",
    color: "#ff0000"
  },
  cardProductDesciprion: {
    height: "80px",    
    overflow: "hidden",
    color: "rgba(0, 0, 0, 0.6)",
    fontFamily: "Open Sans, sans-serif"
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

export default athenaManufacturingCardStyle;
