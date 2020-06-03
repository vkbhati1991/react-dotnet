import React from 'react';
import { MnForm } from '../../MnForm/MnForm';
import { LoginFormFields } from "./LoginFields";
import { LoginFormLayout } from "./LoginFormLayout";
import { model } from "./LoginModal";


export const LoginForm = () => {

    const onSubmit = data => console.log(data);

    return (
        <MnForm
            fields={LoginFormFields}
            postData={model}
            layout={LoginFormLayout}
            handleOnSubmit={onSubmit}
            actions={[{
                text: "Login",
                type: "Submit"
            }]}
        />
    );
}