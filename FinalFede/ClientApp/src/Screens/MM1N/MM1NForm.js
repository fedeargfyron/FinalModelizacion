import React from 'react';
import { useForm } from "react-hook-form"
import Form from '../../Components/Shared/Form'
import MetricsBaseInputs from '../../Components/Shared/MetricsBaseInputs'
import Input from '../../Components/Shared/Input'



const MM1NForm = ({ populateMetrics }) => {
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm();

    return (
        <Form onSubmit={handleSubmit((data) => populateMetrics(data))}>
            <MetricsBaseInputs errors={errors} register={register} />
            <Input register={register} requiredTags={{ required: "This field is required" }} errors={errors} name="QueueLength" placeholder="Queue length" />
            <Input register={register} errors={errors} name="NUnits" placeholder="N Units" />
        </Form> 
    );
}

export default MM1NForm;