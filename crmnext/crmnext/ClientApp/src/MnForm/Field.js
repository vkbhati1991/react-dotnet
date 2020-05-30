import React, { Component } from "react";
import PropTypes from "prop-types";
import Input from "./Input";

class Field extends Component {
    static propTypes = {
        controlKey: PropTypes.string,
        label: PropTypes.string,
        value: PropTypes.any,
        className: PropTypes.string,
        required: PropTypes.bool,
        validation: PropTypes.array,
        autoComplete: PropTypes.string,
        showLabel: PropTypes.bool
    }

    static defaultProps = {
        showLabel: false
    }

    getFieldLabel = () => {
        const { label, showLabel } = this.props;
        if (showLabel) {
            return <div className="field-label">{label}</div>
        }
    }

    getInputField = () => {
        return <Input {...this.props} />;
    }

    render() {
        return (<div className="field mb-16">
            {this.getFieldLabel()}
            <div className="field-value">{this.getInputField()}</div>
        </div>)
    }
}

export default Field;