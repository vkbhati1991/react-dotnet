import React, { Component } from "react";
import TextBox from "./FormControls/TextBox";

class Input extends Component {

    getInputField = () => {
        const types = this.props.types;

        switch (types) {
            case "text":
            case "password":
                return <TextBox {...this.props} />
            default:
                return <TextBox {...this.props} />
        }
    }

    render() {
        return this.getInputField();
    }
}

export default Input;