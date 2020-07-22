import React from 'react';

class Select extends React.Component {
    render() {
        const { id, name, classes, tabIndex, placeHolder, options} = this.props;
        return (  
            <select id={id} name={name} tabindex={tabIndex} class={classes} placeholder={placeHolder}>                             
              {options.map((item, key) => {
                return (
                  <option value={item.value}>{item.content}</option>
                );}                      
              )}      
            </select>
        );
    }
}

export default Select;
