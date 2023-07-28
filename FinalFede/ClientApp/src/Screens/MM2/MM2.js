import React, { Component } from 'react';
import MM2Form from './MM2Form';
import MetricsTable from '../../Components/Shared/MetricsTable';

export class MM2 extends Component {
    constructor(props) {
        super(props);
        this.state = {
            metrics: {},
            loading: true
        };
    }

    populateMetrics = async (inputs) => {
        console.log(inputs);
        const response = await fetch('queue/mm2', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json;charset=utf-8'
            },
            body: JSON.stringify(inputs)
        });

        const data = await response.json();
        this.setState({ metrics: data, loading: false });
    }

    render() {
        let contents = this.state.loading ? <></>
            : <MetricsTable metrics={this.state.metrics} />;

        return (
            <div>
                <MM2Form populateMetrics={this.populateMetrics} />
                {contents}
            </div>
        );
    }
}
