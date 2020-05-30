import { CreateField } from "../../Utilities/index";

const loginFormFields = {

    LOGIN_USERNAME: CreateField({
        controlKey: "LOGIN_USERNAME",
        label: "username",
        className: "form-control",
        placeholder: "UserName",
        value: "",
        validations: {
            required: { message: "UserName is Required" }
        }
    }),
    LOGIN_PASSWORD: CreateField({
        controlKey: "LOGIN_PASSWORD",
        label: "password",
        value: "",
        className: "form-control",
        placeholder: "Password",
        validations: {
            required: { message: "Password is Required" }
        }
    })
}


function LoginFormFields() {
    return loginFormFields;
}

export default LoginFormFields();