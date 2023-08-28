<script lang="ts">
  import { Router, Route } from "svelte-routing";
  import HomePage from '$pages/Portal/Home/Index.svelte';
  export let url = "";
</script>
<Router {url}>
  <Route path="/" component={HomePage} />
</Router>
