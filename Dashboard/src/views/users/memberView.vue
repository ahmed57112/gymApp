<template>
    <Card>
        <template #title>MEMBERS</template>
        <template #subtitle><Button label="Add Member" @click="routeAddPage" /></template>
        <template #content>
            <Grid></Grid>
        </template>
        <template #footer></template>

    </Card>
</template>

<script setup lang="ts">

import { useRouter } from 'vue-router';

import Card from 'primevue/card';
import Grid from './GridView.vue';
import Button from 'primevue/button';
const router = useRouter()

//add busniss
const routeAddPage = () => {
    router.push('/addMember');
}



</script>