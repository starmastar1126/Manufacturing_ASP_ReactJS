import React from 'react';
import Modal from 'react-awesome-modal';

class RegisterDialog extends React.Component {
  
  render() {
    const { visible } = this.props;
    return (
      <Modal 
          visible={visible}
          width="320"
          height="180"
          effect="fadeInDown"
          onClickAway={this.props.registerHandler}
      >
          <div className="modal-header">
            <button type="button" className="close" data-dismiss="modal" aria-label="Close" onClick={this.props.registerHandler}>
              <span aria-hidden="true">×</span>
            </button>
            <h4 className="modal-title" id="myModalLabel" style={{textAlign: 'center'}}>Register as</h4>
          </div>
          <div className="modal-body">
            <div className="register_btn" style={{marginTop: '10px'}}>
              <a href="/business-package-selection-page">Register as Business User</a>
            </div>
            <br/>
            <div className="register_btn" style={{marginTop: '0px'}}>
              <a href="/individual-registration-page">Register as Individual</a>
            </div>
          </div>
      </Modal>
    );
  }
}

export default RegisterDialog;
