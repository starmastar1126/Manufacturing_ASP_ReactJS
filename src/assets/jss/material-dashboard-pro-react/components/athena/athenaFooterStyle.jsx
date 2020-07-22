import {
  defaultFont,
  container,
  containerFluid,
  primaryColor,
  whiteColor,
  grayColor
} from "assets/jss/material-dashboard-pro-react.jsx";

const athenaFooterStyle = {
  block: {},
  left: {
    float: "left!important",
    display: "block"
  },
  right: {
    margin: "0",
    fontSize: "14px",
    float: "right!important",
    padding: "15px"
  },
  footer: {
    bottom: "0",
    borderTop: "0px solid " + grayColor[15],
    padding: "0 0",
    paddingBottom: "0",
    ...defaultFont,
    zIndex: 4
  },
  container: {
    zIndex: 3,
    ...container,
    padding: "15px 0 0 0",
    backgroundColor: '#12181E',
    position: "relative"
  },
  containerDiv: {
    zIndex: 3,
    // ...container,
    paddingRight: "15px",
    paddingLeft: "15px",
    marginRight: "auto",
    marginLeft: "auto",
    "@media (min-width: 768px)": {
      width: "100%"
    },
    "@media (min-width: 992px)": {
      width: "100%"
    },
    "@media (min-width: 1200px)": {
      width: "100%"
    },
    "&:before,&:after": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      clear: "both"
    },
    padding: "15px 0 0 0",
    backgroundColor: '#12181E',
    position: "relative"
  },
  containerFluid: {
    zIndex: 3,
    ...containerFluid,
    position: "relative"
  },
  a: {
    color: primaryColor[0],
    textDecoration: "none",
    backgroundColor: "transparent"
  },
  list: {
    marginBottom: "0",
    padding: "0",
    marginTop: "0"
  },
  inlineBlock: {
    display: "inline-block",
    padding: "0",
    width: "auto"
  },
  whiteColor: {
    "&,&:hover,&:focus": {
      color: whiteColor
    }
  },
  athenaContainer: {
    zIndex: 3,
    ...container,
    padding: "45px 0 25px 0",
    backgroundColor: '#232D37',
    position: "relative"
  },
  athenaContainerDiv: {
    zIndex: 3,
    // ...container,
    marginRight: "auto",
    marginLeft: "auto",
    "@media (min-width: 768px)": {
      width: "100%"
    },
    "@media (min-width: 992px)": {
      width: "100%"
    },
    "@media (min-width: 1200px)": {
      width: "100%"
    },
    "&:before,&:after": {
      display: "table",
      content: '" "'
    },
    "&:after": {
      clear: "both"
    },
    padding: "0 15px 0 15px",
    backgroundColor: '#232D37',
    position: "relative"
  },
  athenaTitle: {
    fontWeight: "500",
    textAlign: "center"
  },
  center: {
    textAlign: "center"
  },
  leftAlign: {
    textAlign: "left"
  },
  boldFont: {
    fontSize: "15px",
    fontWeight: "800"
  },
  font13: {
    fontSize: "13px"
  },
  font15: {
    fontSize: "15px"
  },
  underLine: {
    underLine: "1px"
  },
  imageSize: {
    width: "30px",
    height: "30px"
  },
  height30: {
    height: "30px"
  },
  middle: {
    verticalAlign: "middle"
  }
};
export default athenaFooterStyle;
