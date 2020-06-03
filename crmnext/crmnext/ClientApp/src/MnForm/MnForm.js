import React, { useState, useEffect } from 'react';
import { MnLayout } from '../MnLayout';
import { getPostData, validate } from "./FormUtility/index";


function MnForm(props) {

    const { handleOnSubmit, actions, layout } = props;
    const [fields, setFields] = useState(props.fields);
    const [postData, setPostData] = useState(null);
    const errorArray = [];

    useEffect(() => {

        const postdata = getPostData(props, fields);
        setPostData(postdata);

    }, [props, fields]);


    const postOnSubmitData = () => {

        const isValid = validate(fields, setFields, errorArray);

        if (isValid) {
            handleOnSubmit && handleOnSubmit(postData);
        }
        return null;
    }

    function setValue(controkKey, fieldValue) {

        const { ...fieldsCopy } = fields;

        const field = fieldsCopy[controkKey];
        field["value"] = fieldValue;

        const pdata = getPostData(props, fields);

        setFields(fieldsCopy);
        setPostData(pdata);

    }

    function getMnLayout() {
        return (
            <div>
                <MnLayout
                    fields={fields}
                    setValue={setValue}
                    layout={layout}
                />
            </div>
        );

    }

    function getFormActions() {
        return actions.map((action, idx) => {
            return <button key={idx} onClick={postOnSubmitData} className="button button--brand">{action.text}</button>
        });
    }

    return (
        <div className="MnForm">
            {getMnLayout()}
            {getFormActions()}
        </div>
    );
}

export { MnForm };