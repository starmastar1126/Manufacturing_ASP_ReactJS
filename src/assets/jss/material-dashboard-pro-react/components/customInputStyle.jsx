import {
  primaryColor,
  dangerColor,
  successColor,
  defaultFont,
  whiteColor,
  grayColor
} from "assets/jss/material-dashboard-pro-react.jsx";

const customInputStyle = {
  disabled: {
    "&:before": {
      borderColor: "transparent !important"
    }
  },
  underline: {
    "&:hover:not($disabled):before,&:before": {
      borderColor: grayColor[4] + "!important",
      borderWidth: "1px !important"
    },
    "&:after": {
      borderColor: primaryColor[0]
    }
  },
  underlineError: {
    "&:after": {
      borderColor: dangerColor[0]
    }
  },
  underlineSuccess: {
    "&:after": {
      borderColor: successColor[0]
    }
  },
  labelRoot: {
    ...defaultFont,
    color: grayColor[3] + " !important",
    fontWeight: "400",
    fontSize: "14px",
    lineHeight: "1.42857",
    top: "10px",
    "& + $underline": {
      marginTop: "0px"
    }
  },
  labelRootError: {
    color: dangerColor[0] + " !important"
  },
  labelRootSuccess: {
    color: successColor[0] + " !important"
  },
  formControl: {
    margin: "0 0 17px 0",
    paddingTop: "27px",
    position: "relative",
    verticalAlign: "unset",
    "& svg,& .fab,& .far,& .fal,& .fas,& .material-icons": {
      color: grayColor[14]
    }
  },
  whiteUnderline: {
    "&:hover:not($disabled):before,&:before": {
      backgroundColor: whiteColor
    },
    "&:after": {
      backgroundColor: whiteColor
    }
  },
  input: {
    color: grayColor[14],
    "&,&::placeholder": {
      fontSize: "14px",
      fontFamily: '"Roboto", "Helvetica", "Arial", sans-serif',
      fontWeight: "400",
      lineHeight: "1.42857",
      opacity: "1"
    },
    "&::placeholder": {
      color: grayColor[3]
    }
  },
  whiteInput: {
    "&,&::placeholder": {
      color: whiteColor,
      opacity: "1"
    }
  }
};

export default customInputStyle;
