const loginLayoutJson = [
    {
        "TabId": 1,
        "Label": "Key Information",
        "Sections": [
            {
                "Label": "Key Information",
                "SectionId": "1_0",
                "Rows": [
                    {
                        "Cells": [
                            {
                                "ControlKey": "LOGIN_USERNAME"
                            }
                        ]
                    },
                    {
                        "Cells": [
                            {
                                "ControlKey": "LOGIN_PASSWORD"
                            }
                        ]
                    }
                ]
            }
        ]
    }

]

export const LoginFormLayout = () => {
    return { Tabs: loginLayoutJson }
}