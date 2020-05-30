import React, { Component } from "react";
import Field from "../MnForm/Field";

class MnLayout extends Component {

    getRows = (rowsArray) => {
        return rowsArray.map((cell, idx) => {
            return this.getCells(cell);
        })
    }
    getCells = (cellArray) => {
        return cellArray.Cells.map((field, idx) => {
            return <div>{this.getField(field)}</div>;
        })
    }
    getField = (field) => {

        const controlKey = field.ControlKey;
        const fieldProps = this.props.fields[controlKey];
        return <Field {...fieldProps} setValue={this.props.setValue} />;


    }

    render() {
        if (!this.props.layout) {
            return;
        }
        const { Rows } = this.props.layout["Tabs"][0].Sections[0];

        return (
            <div className="mnLayout">
                {this.getRows(Rows)}
            </div>
        );
    }
}

export default MnLayout;