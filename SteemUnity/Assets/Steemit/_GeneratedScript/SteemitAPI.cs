namespace Steemit
{
	public class SteemitAPI
	{
		/// Auto Generated Begin

		private void set_subscribe_callback(string callback,string clearFilter)
		{
		}

		private void set_pending_transaction_callback(string cb)
		{
		}

		private void set_block_applied_callback(string cb)
		{
		}

		private void cancel_all_subscriptions()
		{
		}

		private void get_trending_tags(string afterTag,string limit)
		{
		}

		private void get_tags_used_by_author(string author)
		{
		}

		private void get_post_discussions_by_payout(string query)
		{
		}

		private void get_comment_discussions_by_payout(string query)
		{
		}

		private void get_discussions_by_trending(string query)
		{
		}

		private void get_discussions_by_trending30(string query)
		{
		}

		private void get_discussions_by_created(string query)
		{
		}

		private void get_discussions_by_active(string query)
		{
		}

		private void get_discussions_by_cashout(string query)
		{
		}

		private void get_discussions_by_payout(string query)
		{
		}

		private void get_discussions_by_votes(string query)
		{
		}

		private void get_discussions_by_children(string query)
		{
		}

		private void get_discussions_by_hot(string query)
		{
		}

		private void get_discussions_by_feed(string query)
		{
		}

		private void get_discussions_by_blog(string query)
		{
		}

		private void get_discussions_by_comments(string query)
		{
		}

		private void get_discussions_by_promoted(string query)
		{
		}

		private void get_block_header(string blockNum)
		{
		}

		private void get_block(string blockNum)
		{
		}

		private void get_ops_in_block(string blockNum,string onlyVirtual)
		{
		}

		private void get_state(string path)
		{
		}

		private void get_trending_categories(string after,string limit)
		{
		}

		private void get_best_categories(string after,string limit)
		{
		}

		private void get_active_categories(string after,string limit)
		{
		}

		private void get_recent_categories(string after,string limit)
		{
		}

		private void get_config()
		{
		}

		private void get_dynamic_global_properties()
		{
		}

		private void get_chain_properties()
		{
		}

		private void get_feed_history()
		{
		}

		private void get_current_median_history_price()
		{
		}

		private void get_witness_schedule()
		{
		}

		private void get_hardfork_version()
		{
		}

		private void get_next_scheduled_hardfork()
		{
		}

		private void get_key_references(string key)
		{
		}

		private void get_accounts(string names)
		{
		}

		private void get_account_references(string accountId)
		{
		}

		private void lookup_account_names(string accountNames)
		{
		}

		private void lookup_accounts(string lowerBoundName,string limit)
		{
		}

		private void get_account_count()
		{
		}

		private void get_conversion_requests(string accountName)
		{
		}

		private void get_account_history(string account,string from,string limit)
		{
		}

		private void get_owner_history(string account)
		{
		}

		private void get_recovery_request(string account)
		{
		}

		private void get_escrow(string from,string escrowId)
		{
		}

		private void get_withdraw_routes(string account,string withdrawRouteType)
		{
		}

		private void get_account_bandwidth(string account,string bandwidthType)
		{
		}

		private void get_savings_withdraw_from(string account)
		{
		}

		private void get_savings_withdraw_to(string account)
		{
		}

		private void get_order_book(string limit)
		{
		}

		private void get_open_orders(string owner)
		{
		}

		private void get_liquidity_queue(string startAccount,string limit)
		{
		}

		private void get_transaction_hex(string trx)
		{
		}

		private void get_transaction(string trxId)
		{
		}

		private void get_required_signatures(string trx,string availableKeys)
		{
		}

		private void get_potential_signatures(string trx)
		{
		}

		private void verify_authority(string trx)
		{
		}

		private void verify_account_authority(string nameOrId,string signers)
		{
		}

		private void get_active_votes(string author,string permlink)
		{
		}

		private void get_account_votes(string voter)
		{
		}

		private void get_content(string author,string permlink)
		{
		}

		private void get_content_replies(string author,string permlink)
		{
		}

		private void get_discussions_by_author_before_date(string author,string startPermlink,string beforeDate,string limit)
		{
		}

		private void get_replies_by_last_update(string startAuthor,string startPermlink,string limit)
		{
		}

		private void get_witnesses(string witnessIds)
		{
		}

		private void get_witness_by_account(string accountName)
		{
		}

		private void get_witnesses_by_vote(string from,string limit)
		{
		}

		private void lookup_witness_accounts(string lowerBoundName,string limit)
		{
		}

		private void get_witness_count()
		{
		}

		private void get_active_witnesses()
		{
		}

		private void get_miner_queue()
		{
		}

		private void get_reward_fund(string name)
		{
		}

		private void get_vesting_delegations(string account,string from,string limit)
		{
		}

		private void login(string username,string password)
		{
		}

		private void get_api_by_name(string database_api)
		{
		}

		private void get_version()
		{
		}

		private void get_followers(string following,string startFollower,string followType,string limit)
		{
		}

		private void get_following(string follower,string startFollowing,string followType,string limit)
		{
		}

		private void get_follow_count(string account)
		{
		}

		private void get_feed_entries(string account,string entryId,string limit)
		{
		}

		private void get_feed(string account,string entryId,string limit)
		{
		}

		private void get_blog_entries(string account,string entryId,string limit)
		{
		}

		private void get_blog(string account,string entryId,string limit)
		{
		}

		private void get_account_reputations(string lowerBoundName,string limit)
		{
		}

		private void get_reblogged_by(string author,string permlink)
		{
		}

		private void get_blog_authors(string blogAccount)
		{
		}

		private void broadcast_transaction(string trx)
		{
		}

		private void broadcast_transaction_with_callback(string confirmationCallback,string trx)
		{
		}

		private void broadcast_transaction_synchronous(string trx)
		{
		}

		private void broadcast_block(string b)
		{
		}

		private void set_max_block_age(string maxBlockAge)
		{
		}

		private void get_ticker()
		{
		}

		private void get_volume()
		{
		}

		private void getMarketOrderBook(string limit)
		{
		}

		private void get_trade_history(string start,string end,string limit)
		{
		}

		private void get_recent_trades(string limit)
		{
		}

		private void get_market_history(string bucket_seconds,string start,string end)
		{
		}

		private void get_market_history_buckets()
		{
		}
		/// Auto Generated End
	}
}