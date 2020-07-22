import {
    primaryColor,
    primaryBoxShadow,
    whiteColor,
    blackColor,
    grayColor,
  } from "assets/jss/material-dashboard-pro-react.jsx";

import customSelectStyle from "assets/jss/material-dashboard-pro-react/customSelectStyle.jsx";
  
const athenaSelectStyle = {
    athenaSelect: {
        padding: "14px 0 7px",
        color: grayColor[8],
        backgroundColor: "transparent",
        textAlign: 'left',
        "&[aria-owns] + input + svg": {
            padding: "5px 0 0px",
            transform: "rotate(180deg)",
            color: grayColor[3] + " !important",
        },
        "& + input + svg": {
            margin: "4px 0 0px",
            transition: "all 300ms linear",
            color: grayColor[3] + " !important",
        }
    },
    athenaSelectFormControl: {
        "& > div": {
          "&:before": {
            borderBottomWidth: "1px !important",
            borderBottomColor: grayColor[4] + "!important"
          },
          "&:after": {
            borderBottomColor: primaryColor[0] + "!important"
          }
        }
    },
    athenaSelectLabel: {
        padding: "10px 0 7px",
        color: grayColor[3] + " !important",
    },
    athenaSelectMenu: {
        backgroundColor: "transparent",
        "& > div + div": {
          maxHeight: "266px !important"
        }
    },
    athenaSelectMenuItem: {
    },
    athenaSelectMenuItemSelected: {
    },
    athenaSelectMenuItemSelectedMultiple: {
    },
};
  
export default athenaSelectStyle;
  