//Set Object Modal for Post Data
function getPostData(props, fields) {

    const postDataObject = {};

    Object.keys(props.postData).forEach((keys) => {
        const fieldKey = props.postData[keys].key;
        postDataObject[keys] = fields[fieldKey].value;
    });

    return postDataObject;
}

//Check Validation for All Fields
function checkValidation(value, validations) {

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

//Validate ModalState or Form
function validate(fields, setFields, errorArray) {
    const fieldsWithError = {};

    Object.keys(fields).forEach((field) => {
        const currentfield = fields[field];
        const { isError, message } = checkValidation(currentfield.value, currentfield.validations);
        const fieldIndex = errorArray.findIndex(f => f === field);
        if (isError) {
            currentfield["hasError"] = true;
            currentfield["validateMessage"] = message;
            fieldIndex < 0 && errorArray.push(field);
        } else {
            currentfield["hasError"] = false;
            currentfield["validateMessage"] = "";
            errorArray.splice(fieldIndex, 1);
        }

        fieldsWithError[field] = currentfield;
    });

    setFields(fieldsWithError);

    return errorArray.length === 0;
}

export { getPostData, validate };