<template>
    <DataTable :value="members" showGridlines class="w-auto  content-center" :layout="layout">
        <template #header>
            <div class="flex justify-content-end">
                <DataViewLayoutOptions v-model="layout" />
            </div>
        </template>
        <Column field="name" header="name" class="flex content-center"></Column>
        <Column field="nationaL_ID" header="NATIONAL_ID"></Column>
        <Column field="membeR_TYPE" header="MEMBER_TYPE"></Column>



    </DataTable>
</template>

<script setup lang="ts">

import DataTable from 'primevue/datatable';
import Column from 'primevue/column';

import DataView from 'primevue/dataview';
import DataViewLayoutOptions from 'primevue/dataviewlayoutoptions'

import axios from 'axios';
import { ref, onMounted } from 'vue';

const layout = ref('grid');
const members = ref([]);

const getData = () => {
    debugger

    axios.get('https://localhost:7073/MEMBER/GetData').then((response) => {

        members.value = response.data

    })


}
getData()
</script>