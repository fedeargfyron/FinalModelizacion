import React from 'react';
import { useForm } from "react-hook-form"
import Form from '../../Components/Shared/Form'
import MetricsBaseInputs from '../../Components/Shared/MetricsBaseInputs'
import InputWithTimeUnit from '../../Components/Shared/InputWithTimeUnit'
import Input from '../../Components/Shared/Input'

const MG1Form = ({ populateMetrics }) => {
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm();

    return (
        <Form onSubmit={handleSubmit((data) => populateMetrics(data))}>
            <MetricsBaseInputs register={register} errors={errors} />
            <InputWithTimeUnit requiredTags={{ required: "This field is required" }} register={register} errors={errors} name="StandardDeviation" placeholder="Standard deviation" />
            <Input register={register} errors={errors} name="NUnits" placeholder="N Units" />
        </Form> 
    );
}

export default MG1Form;