import React, { Component } from 'react';
import PropTypes from "prop-types";

export default class TextBox extends Component {

    static propTypes = {
        name: PropTypes.string,
        type: PropTypes.string,
        className: PropTypes.string,
        placeholder: PropTypes.string,
        isMandotary: PropTypes.string,
        isValid: PropTypes.bool,
        message: PropTypes.string,
        defaultValue: PropTypes.any,
        handleOnChange: PropTypes.func,
        autoComplete: PropTypes.string
    }

    handleOnChnage = (event) => {
        this.props.setValue && this.props.setValue(this.props.controlKey, event.target.value);
    }

    render() {
        const { name, type, autoComplete, className, placeholder, isMandotary, hasError, validateMessage } = this.props;
        
        const classValue = hasError ? `form-control--error ${className}`: className

        return (
            <React.Fragment>
                <div className="input-group">
                    <input
                        type={type}
                        name={name}
                        className={classValue}
                        placeholder={placeholder}
                        defaultValue={this.props.value}
                        autoComplete={autoComplete}
                        onChange={(e) => this.handleOnChnage(e)}

                    />
                    {isMandotary && <span className="form-control--star">*</span>}
                </div>
                {hasError && <div className="form-control--help red pt-8">{validateMessage}</div>}
            </React.Fragment>
        );
    }
}
