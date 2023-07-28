import React from 'react';
import { useForm } from "react-hook-form"
import Form from '../../Components/Shared/Form'
import MetricsBaseInputs from '../../Components/Shared/MetricsBaseInputs'
import InputWithTimeUnit from '../../Components/Shared/InputWithTimeUnit'
import Input from '../../Components/Shared/Input'
import Checkbox from '../../Components/Shared/Checkbox'


const MM2Form = ({ populateMetrics }) => {
    const {
        register,
        handleSubmit,
        formState: { errors }
    } = useForm();

    return (
        <Form onSubmit={handleSubmit((data) => populateMetrics(data))}>
            <MetricsBaseInputs register={register} errors={errors} />
            <InputWithTimeUnit register={register} requiredTags={{ required: "This field is required" }} errors={errors} name="SecondService" placeholder="Service" />
            <Input register={register} errors={errors} name="NUnits" placeholder="N Units" />
            <Checkbox register={register} name="ServiceSelection" placeholder="With service selection" />
        </Form> 
    );
}

export default MM2Form;