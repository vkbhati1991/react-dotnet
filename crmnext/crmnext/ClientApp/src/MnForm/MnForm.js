import React, { Component } from 'react';
import MnLayout from '../MnLayout';

class MnForm extends Component {
    constructor(props) {
        super(props);
        this.state = {
            fields: props.fields,
            postData: ""
        }

        this.errorArray = [];
    }

    componentDidMount() {
        this.setState({
            postData: this.getPostData(),
        });
    }

    checkValidation = (value, validations) => {

        const { required, length } = validations;

        if (required) {
            const requiredMessage = required.message;
            if (value === "") {
                return {
                    isError: true,
                    message: requiredMessage
                }
            }
        }

        if (length) {
            if (value.length < 5 || value.length > 20) {
                return {
                    isError: true,
                    message: "length is small"
                }
            }
        }

        return {
            isError: false,
            message: "length is small"
        }
    }

    validate = () => {
        //Login For Validate all fields
        const fieldsWithError = {};

        Object.keys(this.state.fields).forEach((field) => {
            const currentfield = this.state.fields[field];
            const { isError, message } = this.checkValidation(currentfield.value, currentfield.validations);
            const fieldIndex = this.errorArray.findIndex(f => f === field);
            if (isError) {
                currentfield["hasError"] = true;
                currentfield["validateMessage"] = message;
                fieldIndex < 0 && this.errorArray.push(field);
            } else {
                currentfield["hasError"] = false;
                currentfield["validateMessage"] = "";
                this.errorArray.splice(fieldIndex, 1);
            }

            fieldsWithError[field] = currentfield;

        });

        this.setState({
            fields: fieldsWithError
        })

        return this.errorArray.length === 0;
    }


    postOnSubmitData = () => {
        if (this.validate()) {
            this.props.handleOnSubmit && this.props.handleOnSubmit(this.state.postData);
        }
        return null;
    }
    

    getPostData = () => {
        const postDataObject = {};

        Object.keys(this.props.postData).forEach((keys) => {
            const fieldKey = this.props.postData[keys].key;

            postDataObject[keys] = this.state.fields[fieldKey].value;
        });

        return postDataObject;
    }

    setValue = (controkKey, fieldValue) => {

        const { ...fieldsCopy } = this.state.fields;

        const field = fieldsCopy[controkKey];
        field["value"] = fieldValue;

        this.setState({
            fields: fieldsCopy,
            postData: this.getPostData()
        })
    }

    getMnLayout = () => {
        return (
            <div>
                <MnLayout
                    fields={this.state.fields}
                    setValue={this.setValue}
                    layout={this.props.layout}
                />
            </div>
        );

    }

    getFormActions = () => {
        return this.props.actions.map((action, idx) => {
            return <button onClick={this.postOnSubmitData} className="button button--brand">{action.text}</button>
        });
    }

    render() {

        return (
            <div className="MnForm">
                {this.getMnLayout()}
                {this.getFormActions()}
            </div>
        );

    }
}

export default MnForm;