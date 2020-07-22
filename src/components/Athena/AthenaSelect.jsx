import React from "react";
import PropTypes from "prop-types";

// @material-ui/core components
import withStyles from "@material-ui/core/styles/withStyles";
import FormControl from "@material-ui/core/FormControl";
import InputLabel from "@material-ui/core/InputLabel";
import Select from "@material-ui/core/Select";
import MenuItem from "@material-ui/core/MenuItem";

import athenaSelectStyle from "assets/jss/material-dashboard-pro-react/components/athena/athenaSelectStyle.jsx";

function AthenaSelect({ ...props }) {
    const {
      classes,
      label,
      placeholder,
      menuItems,
      value,
      onChange,
      name,
      id,
    } = props;
    return (
        <FormControl
            fullWidth
            className={`${classes.selectFormControl} ${classes.athenaSelectFormControl}`}
        >
            <InputLabel
                htmlFor="simple-select"
                className={`${classes.selectLabel} ${classes.athenaSelectLabel}`}
            >
                {label}
            </InputLabel>
            <Select
                value={value}
                onChange={onChange}
                MenuProps={{
                    className: `${classes.selectMenu} ${classes.athenaSelectMenu}`
                }}
                classes={{
                    select: `${classes.select} ${classes.athenaSelect}`
                }}
                inputProps={{
                    name: {name},
                    id: {id}
                }}
            >
                <MenuItem
                    disabled
                    classes={{
                        root: `${classes.selectMenuItem} ${classes.athenaSelectMenuItem}`
                    }}
                >
                {placeholder}
                </MenuItem>
                    {menuItems.map((item, key) => {
                        return (
                            <MenuItem
                                classes={{
                                    root: classes.selectMenuItem,
                                    selected: classes.selectMenuItemSelected
                                }}
                                value={item.value}
                            >
                                {item.text}
                            </MenuItem>
                        );
                    }
                )}
            </Select>
        </FormControl>
    )
}

export default withStyles(athenaSelectStyle)(AthenaSelect);
