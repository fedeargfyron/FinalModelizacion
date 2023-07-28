import React from 'react';
import InputWithTimeUnit from './InputWithTimeUnit'

const MetricsBaseInputs = ({ register, errors }) => {
    let requiredTags = {
        required: "This field si required"
    }
    return (
        <>
            <InputWithTimeUnit register={register} errors={errors} requiredTags={requiredTags} name="Arrive" />
            <InputWithTimeUnit register={register} errors={errors} requiredTags={requiredTags} name="Service" />
        </>);
}

export default MetricsBaseInputs;