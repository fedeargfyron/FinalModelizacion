import React from 'react';
import { useForm } from "react-hook-form"
import Form from '../../Components/Shared/Form'
import MetricsBaseInputs from '../../Components/Shared/MetricsBaseInputs'
import Input from '../../Components/Shared/Input'


const MM1Form = ({ populateMetrics }) => {
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm();

    return (
        <Form onSubmit={handleSubmit((data) => populateMetrics(data))}>
            <MetricsBaseInputs register={register} errors={errors} />
            <Input register={register} errors={errors} name="NUnits" placeholder="N Units" />
        </Form> 
    );
}

export default MM1Form;